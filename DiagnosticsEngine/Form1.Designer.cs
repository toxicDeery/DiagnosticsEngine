namespace DiagnosticsEngine
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOpened = new System.Windows.Forms.Label();
            this.buttonReading = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSeconds = new System.Windows.Forms.TextBox();
            this.chartAF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonFourierFT = new System.Windows.Forms.Button();
            this.chartFourier = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSelSize = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chartAF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFourier)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 25);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(112, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Открыть файл";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл:";
            // 
            // labelOpened
            // 
            this.labelOpened.AutoSize = true;
            this.labelOpened.Location = new System.Drawing.Point(58, 9);
            this.labelOpened.Name = "labelOpened";
            this.labelOpened.Size = new System.Drawing.Size(67, 13);
            this.labelOpened.TabIndex = 2;
            this.labelOpened.Text = "labelOpened";
            // 
            // buttonReading
            // 
            this.buttonReading.Location = new System.Drawing.Point(139, 25);
            this.buttonReading.Name = "buttonReading";
            this.buttonReading.Size = new System.Drawing.Size(75, 23);
            this.buttonReading.TabIndex = 3;
            this.buttonReading.Text = "Считать";
            this.buttonReading.UseVisualStyleBackColor = true;
            this.buttonReading.Click += new System.EventHandler(this.buttonReading_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "секунд";
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(220, 27);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(31, 20);
            this.textBoxSeconds.TabIndex = 5;
            // 
            // chartAF
            // 
            chartArea3.Name = "ChartArea1";
            this.chartAF.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartAF.Legends.Add(legend3);
            this.chartAF.Location = new System.Drawing.Point(12, 54);
            this.chartAF.Name = "chartAF";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartAF.Series.Add(series3);
            this.chartAF.Size = new System.Drawing.Size(314, 152);
            this.chartAF.TabIndex = 6;
            this.chartAF.Text = "chart1";
            // 
            // buttonFourierFT
            // 
            this.buttonFourierFT.Location = new System.Drawing.Point(229, 212);
            this.buttonFourierFT.Name = "buttonFourierFT";
            this.buttonFourierFT.Size = new System.Drawing.Size(97, 23);
            this.buttonFourierFT.TabIndex = 7;
            this.buttonFourierFT.Text = "Преобразовать";
            this.buttonFourierFT.UseVisualStyleBackColor = true;
            this.buttonFourierFT.Click += new System.EventHandler(this.buttonFourierFT_Click);
            // 
            // chartFourier
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFourier.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartFourier.Legends.Add(legend4);
            this.chartFourier.Location = new System.Drawing.Point(15, 241);
            this.chartFourier.Name = "chartFourier";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartFourier.Series.Add(series4);
            this.chartFourier.Size = new System.Drawing.Size(311, 165);
            this.chartFourier.TabIndex = 8;
            this.chartFourier.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Размер окна";
            // 
            // comboBoxSelSize
            // 
            this.comboBoxSelSize.FormattingEnabled = true;
            this.comboBoxSelSize.Location = new System.Drawing.Point(95, 214);
            this.comboBoxSelSize.Name = "comboBoxSelSize";
            this.comboBoxSelSize.Size = new System.Drawing.Size(61, 21);
            this.comboBoxSelSize.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.comboBoxSelSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chartFourier);
            this.Controls.Add(this.buttonFourierFT);
            this.Controls.Add(this.chartAF);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonReading);
            this.Controls.Add(this.labelOpened);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFourier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOpened;
        private System.Windows.Forms.Button buttonReading;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSeconds;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAF;
        private System.Windows.Forms.Button buttonFourierFT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFourier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSelSize;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

