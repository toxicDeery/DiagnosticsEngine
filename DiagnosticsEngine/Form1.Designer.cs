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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.buttonSignature = new System.Windows.Forms.Button();
            this.dataGridViewSingature = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chartAF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFourier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingature)).BeginInit();
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
            this.labelOpened.Visible = false;
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
            this.label3.Location = new System.Drawing.Point(1320, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "секунд";
            // 
            // textBoxSeconds
            // 
            this.textBoxSeconds.Location = new System.Drawing.Point(1283, 359);
            this.textBoxSeconds.Name = "textBoxSeconds";
            this.textBoxSeconds.Size = new System.Drawing.Size(31, 20);
            this.textBoxSeconds.TabIndex = 5;
            this.textBoxSeconds.Visible = false;
            // 
            // chartAF
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAF.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAF.Legends.Add(legend1);
            this.chartAF.Location = new System.Drawing.Point(12, 54);
            this.chartAF.Name = "chartAF";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartAF.Series.Add(series1);
            this.chartAF.Size = new System.Drawing.Size(384, 152);
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
            chartArea2.Name = "ChartArea1";
            this.chartFourier.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFourier.Legends.Add(legend2);
            this.chartFourier.Location = new System.Drawing.Point(15, 241);
            this.chartFourier.Name = "chartFourier";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFourier.Series.Add(series2);
            this.chartFourier.Size = new System.Drawing.Size(454, 165);
            this.chartFourier.TabIndex = 8;
            this.chartFourier.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Размерность";
            // 
            // comboBoxSelSize
            // 
            this.comboBoxSelSize.FormattingEnabled = true;
            this.comboBoxSelSize.Location = new System.Drawing.Point(95, 214);
            this.comboBoxSelSize.Name = "comboBoxSelSize";
            this.comboBoxSelSize.Size = new System.Drawing.Size(61, 21);
            this.comboBoxSelSize.TabIndex = 10;
            this.comboBoxSelSize.Text = "2048";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonSignature
            // 
            this.buttonSignature.Location = new System.Drawing.Point(977, 217);
            this.buttonSignature.Name = "buttonSignature";
            this.buttonSignature.Size = new System.Drawing.Size(137, 23);
            this.buttonSignature.TabIndex = 11;
            this.buttonSignature.Text = "Вывести сигнатуру";
            this.buttonSignature.UseVisualStyleBackColor = true;
            this.buttonSignature.Click += new System.EventHandler(this.buttonSignature_Click);
            // 
            // dataGridViewSingature
            // 
            this.dataGridViewSingature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSingature.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridViewSingature.Location = new System.Drawing.Point(466, 54);
            this.dataGridViewSingature.Name = "dataGridViewSingature";
            this.dataGridViewSingature.Size = new System.Drawing.Size(648, 150);
            this.dataGridViewSingature.TabIndex = 12;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Шаг";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "20-100";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "100-500";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "500-1000";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "1000-5000";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "5000-10000";
            this.Column6.Name = "Column6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 432);
            this.Controls.Add(this.dataGridViewSingature);
            this.Controls.Add(this.buttonSignature);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingature)).EndInit();
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
        private System.Windows.Forms.Button buttonSignature;
        private System.Windows.Forms.DataGridView dataGridViewSingature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

