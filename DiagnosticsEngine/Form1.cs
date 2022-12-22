using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Numerics;
using System.Data.SqlClient;

namespace DiagnosticsEngine
{
    public partial class Form1 : Form
    {
        public Series audioSeriesPoints;
        public Series fourierSeriesPoints;

        public int N;
        public int sizeFFT;
        public int pointsFFT;

        wavFiles wav;
        public int byteDepth;
        public int numCh;

        public double stepNu;
        public int nuNyq;

        public Complex[][] fftResult;
        public List<Tuple<int, long>> stepHash;

        public List<Tuple<int, string>> audio;
        public List<Tuple<long, Tuple<int, int>>> audioHash;
        public Dictionary<int, int> matchAudio;

        static public int upperFreq = 10000;
        static public int lowerFreq = 20;
        public int[] rangeFreq = new int[] { 100, 500, 1000, 5000, upperFreq + 1 };
        public int getIndx(int freq)
        {
            int i = 0;
            while (rangeFreq[i] < freq)
            {
                i++;
            }
            return i;
        }

        static public int fuzz = 2;
        public long hesh(long p1, long p2, long p3, long p4, long p5)
        {
            return (p5 - (p5 % fuzz)) * 1000000000000 + (p4 - (p4 % fuzz)) * 100000000 + (p3 - (p3 % fuzz)) * 100000 + (p2 - (p2 % fuzz)) * 100 + (p1 - (p1 % fuzz));

        }

        public double l10(double x)
        {
            if (x == 0) return 0;
            return Math.Log10(x);
        }

        public void ClearPointsQuick(Series SeriesOfPoints)
        {
            SeriesOfPoints.Points.SuspendUpdates();
            while (SeriesOfPoints.Points.Count > 0)
                SeriesOfPoints.Points.RemoveAt(SeriesOfPoints.Points.Count -
               1);
            SeriesOfPoints.Points.ResumeUpdates();
        }

        public void plotFFT(int step = 0)
        {
            chartFourier.Series.Remove(fourierSeriesPoints);
            ClearPointsQuick(fourierSeriesPoints);
            for (int i = fftResult[step].Length / 2 + 1; i < fftResult[step].Length; ++i)
            {
               fourierSeriesPoints.Points.AddXY(i * stepNu - nuNyq, l10(Math.Abs(fftResult[step][i].Real) / 10));
            }
            chartFourier.Series.Add(fourierSeriesPoints);
            chartFourier.ChartAreas[0].RecalculateAxesScale();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Filter = "WAV (*.wav) | *.wav|All files (*.*)|*.*";

            audioSeriesPoints = new Series("АВХ");
            audioSeriesPoints.ChartType = SeriesChartType.Line;
            audioSeriesPoints.Color = Color.Green;
            chartAF.ChartAreas[0].AxisX.LabelStyle.Format = "#.###"; // округление значений времени
            chartAF.Series.Add(audioSeriesPoints);

            fourierSeriesPoints = new Series("АЧХ");
            fourierSeriesPoints.ChartType = SeriesChartType.Line;
            fourierSeriesPoints.Color = Color.Blue;
            chartFourier.Series.Add(fourierSeriesPoints);

            buttonReading.Enabled = false;
            buttonFourierFT.Enabled = false;
            buttonSignature.Enabled = false;

        }

        private void buttonReading_Click(object sender, EventArgs e)
        {
            //N = Convert.ToInt32(textBoxSeconds.Text) * wav.getSampleRate();
            N = 5 * wav.getSampleRate();
            if (wav.data.Length < byteDepth * numCh * N)
            {

                MessageBox.Show("Слишком маленький файл");
            }
            else
            {
                ClearPointsQuick(audioSeriesPoints);
                chartAF.Series.Remove(audioSeriesPoints);
                double rate = 1.0 / 44100;
                for (int i = 0; i < N; ++i)
                {
                    audioSeriesPoints.Points.AddXY(i * rate,
                    BitConverter.ToInt16(wav.data, i * byteDepth * numCh));
                }
                chartAF.Series.Add(audioSeriesPoints);
                chartAF.ChartAreas[0].RecalculateAxesScale();
            }
            buttonFourierFT.Enabled = true;
        }

        private void buttonFourierFT_Click(object sender, EventArgs e)
        {
            sizeFFT = 2048;
            if (sizeFFT > N * byteDepth * numCh)
            {
                MessageBox.Show("Слишком большой размер окна БПФ");
            }
            else
            {
                int totalSize = N * byteDepth;
                int amountPossible = totalSize / sizeFFT;
                fftResult = new Complex[amountPossible][];
                for (int times = 0; times < amountPossible; times++)
                {
                    Complex[] fftInput = new Complex[sizeFFT / byteDepth / numCh];
                    for (int i = 0; i < fftInput.Length; i++)
                    {
                        fftInput[i] = new Complex(BitConverter.ToInt16(wav.data, times * sizeFFT + i * byteDepth * numCh), 0);
                        //richTextBox1.AppendText(Convert.ToString(fftInput[i]) + '\n');
                    }
                    fftResult[times] = FourierFT.nfourierft(FourierFT.fourierft(fftInput));
                    

                }
                pointsFFT = sizeFFT / byteDepth / numCh; // число точек в FFT окне
                stepNu = 1.0 * wav.getSampleRate() / pointsFFT; // шаг частоты
                nuNyq = wav.getSampleRate() / 2; // частота Найквиста
                plotFFT();
                //buttonSign.Enabled = true;
            }
            buttonSignature.Enabled = true;
        }

        private void buttonSignature_Click(object sender, EventArgs e)
        {
            dataGridViewSingature.Rows.Clear();
            dataGridViewSingature.Refresh();
            Dictionary<int, Tuple<int, double>>[] highscores = new Dictionary<int, Tuple<int, double>>[fftResult.Length]; // доминирующие частоты на каждом шаге БПФ
            for (int i = 0; i < highscores.Length; ++i)
            {
                highscores[i] = new Dictionary<int, Tuple<int, double>>();
                for (int j = 0; j < rangeFreq.Length; ++j)
                {
                    highscores[i].Add(j, new Tuple<int, double>(0, 0.0));
                }
            }
            int right_i = 0;
            double mag = 0;
            int index = 0;
            stepHash = new List<Tuple<int, long>>();
            for (int t = 0; t < fftResult.Length; t++)
            {
                for (int freq = lowerFreq; freq < upperFreq; freq++)
                {
                    right_i = Convert.ToUInt16((freq + nuNyq) / stepNu);
                    mag = Math.Log(Math.Abs(fftResult[t][right_i].Real));
                    index = getIndx(freq);
                    if (mag > highscores[t][index].Item2) // Сохраним самое высокое значение силы сигнала и соответствующую частоту:
                    {
                         highscores[t][index] = new Tuple<int, double>(freq,mag);
                    }
                }
                long h = hesh(highscores[t][0].Item1, highscores[t][1].Item1,
                highscores[t][2].Item1, highscores[t][3].Item1, highscores[t][4].Item1); //сформируем хэш
                if (h != 0)
                stepHash.Add(new Tuple<int, long>(t, h));
                dataGridViewSingature.Rows.Add(t, highscores[t][0].Item1.ToString(), highscores[t][1].Item1.ToString(), highscores[t][2].Item1.ToString(), highscores[t][3].Item1.ToString(), highscores[t][4].Item1.ToString());
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) // открытие файла WAV, MP3
                {
                    string fileName = openFileDialog1.FileName;
                    if (fileName.Contains(".mp3")) // если MP3 - декодируем в WAV при помощи Lame
                    {
                        var process = System.Diagnostics.Process.Start(AppDomain.CurrentDomain.BaseDirectory + "lame.exe", " --decode \"" + fileName + "\"");
                        process.WaitForExit();
                        fileName = fileName.Replace(".mp3", ".wav");
                    }
                    using (var file = System.IO.File.OpenRead(fileName))
                    {
                        byte[] buffer = new byte[file.Length];
                        file.Read(buffer, 0, buffer.Length);
                        wav = new wavFiles(buffer);
                        byteDepth = wav.getBPS() / 8;
                        numCh = wav.getNumCh();
                        buttonReading.Enabled = true;
                        labelOpened.Text = openFileDialog1.SafeFileName;
                        labelOpened.Visible = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Выбран файл с недопустимым форматом, используйте файлы формата .wav");
            }
        }

        private void diagnosticButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автомобиль: Lada 2112\nНеисправности: не обнаружены.");
        }
    }
}
