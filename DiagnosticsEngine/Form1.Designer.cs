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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.chartAF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFourier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingature)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(1274, 319);
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
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл:";
            // 
            // labelOpened
            // 
            this.labelOpened.AutoSize = true;
            this.labelOpened.Location = new System.Drawing.Point(54, 34);
            this.labelOpened.Name = "labelOpened";
            this.labelOpened.Size = new System.Drawing.Size(67, 13);
            this.labelOpened.TabIndex = 2;
            this.labelOpened.Text = "labelOpened";
            this.labelOpened.Visible = false;
            // 
            // buttonReading
            // 
            this.buttonReading.Location = new System.Drawing.Point(549, 16);
            this.buttonReading.Name = "buttonReading";
            this.buttonReading.Size = new System.Drawing.Size(97, 23);
            this.buttonReading.TabIndex = 3;
            this.buttonReading.Text = "Считать файл";
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
            chartArea5.Name = "ChartArea1";
            this.chartAF.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartAF.Legends.Add(legend5);
            this.chartAF.Location = new System.Drawing.Point(10, 16);
            this.chartAF.Name = "chartAF";
            series5.ChartArea = "ChartArea1";
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartAF.Series.Add(series5);
            this.chartAF.Size = new System.Drawing.Size(450, 152);
            this.chartAF.TabIndex = 6;
            this.chartAF.Text = "chart1";
            // 
            // buttonFourierFT
            // 
            this.buttonFourierFT.Location = new System.Drawing.Point(549, 204);
            this.buttonFourierFT.Name = "buttonFourierFT";
            this.buttonFourierFT.Size = new System.Drawing.Size(97, 23);
            this.buttonFourierFT.TabIndex = 7;
            this.buttonFourierFT.Text = "Обработать";
            this.buttonFourierFT.UseVisualStyleBackColor = true;
            this.buttonFourierFT.Click += new System.EventHandler(this.buttonFourierFT_Click);
            // 
            // chartFourier
            // 
            chartArea6.Name = "ChartArea1";
            this.chartFourier.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartFourier.Legends.Add(legend6);
            this.chartFourier.Location = new System.Drawing.Point(6, 198);
            this.chartFourier.Name = "chartFourier";
            series6.ChartArea = "ChartArea1";
            series6.IsVisibleInLegend = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartFourier.Series.Add(series6);
            this.chartFourier.Size = new System.Drawing.Size(454, 165);
            this.chartFourier.TabIndex = 8;
            this.chartFourier.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Размерность";
            // 
            // comboBoxSelSize
            // 
            this.comboBoxSelSize.FormattingEnabled = true;
            this.comboBoxSelSize.Location = new System.Drawing.Point(86, 177);
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
            this.buttonSignature.Location = new System.Drawing.Point(7, 15);
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
            this.dataGridViewSingature.Location = new System.Drawing.Point(7, 44);
            this.dataGridViewSingature.Name = "dataGridViewSingature";
            this.dataGridViewSingature.Size = new System.Drawing.Size(648, 319);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(669, 395);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.chartAF);
            this.tabPage1.Controls.Add(this.buttonReading);
            this.tabPage1.Controls.Add(this.chartFourier);
            this.tabPage1.Controls.Add(this.comboBoxSelSize);
            this.tabPage1.Controls.Add(this.buttonFourierFT);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(661, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Анализ входного сигнала";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addButton);
            this.tabPage2.Controls.Add(this.diagnosticButton);
            this.tabPage2.Controls.Add(this.dataGridViewSingature);
            this.tabPage2.Controls.Add(this.buttonSignature);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(661, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Диагностика";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(668, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileToolStripMenuItem.Image")));
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.openFileToolStripMenuItem.Text = "Открыть файл";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripMenuItem.Image")));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // diagnosticButton
            // 
            this.diagnosticButton.Location = new System.Drawing.Point(178, 15);
            this.diagnosticButton.Name = "diagnosticButton";
            this.diagnosticButton.Size = new System.Drawing.Size(109, 23);
            this.diagnosticButton.TabIndex = 13;
            this.diagnosticButton.Text = "Диагностика";
            this.diagnosticButton.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(329, 15);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(661, 369);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчет";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 454);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxSeconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelOpened);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "АИС\"Диагностика\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartAF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFourier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSingature)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button diagnosticButton;
        private System.Windows.Forms.TabPage tabPage3;
    }
}

