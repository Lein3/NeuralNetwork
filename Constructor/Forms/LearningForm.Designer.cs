namespace Constructor
{
    partial class LearningForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_neurons = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_dataset = new System.Windows.Forms.Button();
            this.label_percent = new System.Windows.Forms.Label();
            this.numericUpDown_percent = new System.Windows.Forms.NumericUpDown();
            this.button_start = new System.Windows.Forms.Button();
            this.label_learningRate = new System.Windows.Forms.Label();
            this.numericUpDown_learningRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_learningCount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_errorBarier = new System.Windows.Forms.NumericUpDown();
            this.label_or = new System.Windows.Forms.Label();
            this.radioButton_learningCount = new System.Windows.Forms.RadioButton();
            this.radioButton_errorBarrier = new System.Windows.Forms.RadioButton();
            this.label_fileName = new System.Windows.Forms.Label();
            this.button_readFile = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView_learningData = new System.Windows.Forms.DataGridView();
            this.button_swap = new System.Windows.Forms.Button();
            this.label_learningData = new System.Windows.Forms.Label();
            this.label_testData = new System.Windows.Forms.Label();
            this.dataGridView_testData = new System.Windows.Forms.DataGridView();
            this.label_learningCount = new System.Windows.Forms.Label();
            this.label_testCount = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_percent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_learningRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_learningCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_errorBarier)).BeginInit();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_learningData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_testData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_neurons
            // 
            this.panel_neurons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_neurons.AutoScroll = true;
            this.panel_neurons.BackColor = System.Drawing.Color.White;
            this.panel_neurons.Location = new System.Drawing.Point(646, 246);
            this.panel_neurons.Name = "panel_neurons";
            this.panel_neurons.Size = new System.Drawing.Size(467, 458);
            this.panel_neurons.TabIndex = 5;
            this.panel_neurons.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawSeparator);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button_dataset);
            this.tabPage1.Controls.Add(this.label_percent);
            this.tabPage1.Controls.Add(this.numericUpDown_percent);
            this.tabPage1.Controls.Add(this.button_start);
            this.tabPage1.Controls.Add(this.label_learningRate);
            this.tabPage1.Controls.Add(this.numericUpDown_learningRate);
            this.tabPage1.Controls.Add(this.numericUpDown_learningCount);
            this.tabPage1.Controls.Add(this.numericUpDown_errorBarier);
            this.tabPage1.Controls.Add(this.label_or);
            this.tabPage1.Controls.Add(this.radioButton_learningCount);
            this.tabPage1.Controls.Add(this.radioButton_errorBarrier);
            this.tabPage1.Controls.Add(this.label_fileName);
            this.tabPage1.Controls.Add(this.button_readFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1097, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обучение";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_dataset
            // 
            this.button_dataset.Location = new System.Drawing.Point(360, 140);
            this.button_dataset.Name = "button_dataset";
            this.button_dataset.Size = new System.Drawing.Size(86, 34);
            this.button_dataset.TabIndex = 20;
            this.button_dataset.Text = "Настроить данные";
            this.button_dataset.UseVisualStyleBackColor = true;
            this.button_dataset.Click += new System.EventHandler(this.button_dataset_Click);
            // 
            // label_percent
            // 
            this.label_percent.AutoSize = true;
            this.label_percent.Location = new System.Drawing.Point(47, 139);
            this.label_percent.Name = "label_percent";
            this.label_percent.Size = new System.Drawing.Size(111, 13);
            this.label_percent.TabIndex = 19;
            this.label_percent.Text = "% тестовой выборки";
            // 
            // numericUpDown_percent
            // 
            this.numericUpDown_percent.Location = new System.Drawing.Point(73, 153);
            this.numericUpDown_percent.Name = "numericUpDown_percent";
            this.numericUpDown_percent.Size = new System.Drawing.Size(51, 20);
            this.numericUpDown_percent.TabIndex = 18;
            this.numericUpDown_percent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.Location = new System.Drawing.Point(465, 140);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(86, 34);
            this.button_start.TabIndex = 17;
            this.button_start.Text = "Начать";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // label_learningRate
            // 
            this.label_learningRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_learningRate.AutoSize = true;
            this.label_learningRate.Location = new System.Drawing.Point(766, 123);
            this.label_learningRate.Name = "label_learningRate";
            this.label_learningRate.Size = new System.Drawing.Size(104, 13);
            this.label_learningRate.TabIndex = 16;
            this.label_learningRate.Text = "Скорость обучения";
            // 
            // numericUpDown_learningRate
            // 
            this.numericUpDown_learningRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_learningRate.DecimalPlaces = 2;
            this.numericUpDown_learningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_learningRate.Location = new System.Drawing.Point(759, 139);
            this.numericUpDown_learningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_learningRate.Name = "numericUpDown_learningRate";
            this.numericUpDown_learningRate.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_learningRate.TabIndex = 15;
            this.numericUpDown_learningRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // numericUpDown_learningCount
            // 
            this.numericUpDown_learningCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_learningCount.Location = new System.Drawing.Point(888, 68);
            this.numericUpDown_learningCount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_learningCount.Name = "numericUpDown_learningCount";
            this.numericUpDown_learningCount.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown_learningCount.TabIndex = 14;
            this.numericUpDown_learningCount.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // numericUpDown_errorBarier
            // 
            this.numericUpDown_errorBarier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_errorBarier.DecimalPlaces = 2;
            this.numericUpDown_errorBarier.Enabled = false;
            this.numericUpDown_errorBarier.Location = new System.Drawing.Point(660, 68);
            this.numericUpDown_errorBarier.Name = "numericUpDown_errorBarier";
            this.numericUpDown_errorBarier.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown_errorBarier.TabIndex = 13;
            this.numericUpDown_errorBarier.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label_or
            // 
            this.label_or.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_or.AutoSize = true;
            this.label_or.Location = new System.Drawing.Point(801, 30);
            this.label_or.Name = "label_or";
            this.label_or.Size = new System.Drawing.Size(25, 13);
            this.label_or.TabIndex = 12;
            this.label_or.Text = "или";
            // 
            // radioButton_learningCount
            // 
            this.radioButton_learningCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_learningCount.AutoSize = true;
            this.radioButton_learningCount.Checked = true;
            this.radioButton_learningCount.Location = new System.Drawing.Point(888, 30);
            this.radioButton_learningCount.Name = "radioButton_learningCount";
            this.radioButton_learningCount.Size = new System.Drawing.Size(105, 17);
            this.radioButton_learningCount.TabIndex = 11;
            this.radioButton_learningCount.TabStop = true;
            this.radioButton_learningCount.Text = "Количество раз";
            this.radioButton_learningCount.UseVisualStyleBackColor = true;
            this.radioButton_learningCount.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_errorBarrier
            // 
            this.radioButton_errorBarrier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_errorBarrier.AutoSize = true;
            this.radioButton_errorBarrier.Location = new System.Drawing.Point(660, 30);
            this.radioButton_errorBarrier.Name = "radioButton_errorBarrier";
            this.radioButton_errorBarrier.Size = new System.Drawing.Size(97, 17);
            this.radioButton_errorBarrier.TabIndex = 10;
            this.radioButton_errorBarrier.Text = "Порог ошибки";
            this.radioButton_errorBarrier.UseVisualStyleBackColor = true;
            // 
            // label_fileName
            // 
            this.label_fileName.AutoSize = true;
            this.label_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fileName.Location = new System.Drawing.Point(45, 90);
            this.label_fileName.Name = "label_fileName";
            this.label_fileName.Size = new System.Drawing.Size(78, 25);
            this.label_fileName.TabIndex = 1;
            this.label_fileName.Text = "теекст";
            this.label_fileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_readFile
            // 
            this.button_readFile.Location = new System.Drawing.Point(37, 30);
            this.button_readFile.Name = "button_readFile";
            this.button_readFile.Size = new System.Drawing.Size(515, 45);
            this.button_readFile.TabIndex = 0;
            this.button_readFile.Text = "Прочитать файл";
            this.button_readFile.UseVisualStyleBackColor = true;
            this.button_readFile.Click += new System.EventHandler(this.button_readFile_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1105, 215);
            this.tabControl.TabIndex = 4;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "CSV files (*.csv)|*.csv| txt files (*.txt) | *.txt | All files (*.*)|*.*";
            // 
            // dataGridView_learningData
            // 
            this.dataGridView_learningData.AllowUserToAddRows = false;
            this.dataGridView_learningData.AllowUserToDeleteRows = false;
            this.dataGridView_learningData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_learningData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_learningData.Location = new System.Drawing.Point(15, 245);
            this.dataGridView_learningData.MultiSelect = false;
            this.dataGridView_learningData.Name = "dataGridView_learningData";
            this.dataGridView_learningData.ReadOnly = true;
            this.dataGridView_learningData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_learningData.Size = new System.Drawing.Size(605, 200);
            this.dataGridView_learningData.TabIndex = 6;
            // 
            // button_swap
            // 
            this.button_swap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_swap.Location = new System.Drawing.Point(300, 455);
            this.button_swap.Name = "button_swap";
            this.button_swap.Size = new System.Drawing.Size(56, 41);
            this.button_swap.TabIndex = 8;
            this.button_swap.Text = "<=>";
            this.button_swap.UseVisualStyleBackColor = true;
            this.button_swap.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawSeparator);
            // 
            // label_learningData
            // 
            this.label_learningData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_learningData.Location = new System.Drawing.Point(20, 450);
            this.label_learningData.Name = "label_learningData";
            this.label_learningData.Size = new System.Drawing.Size(120, 30);
            this.label_learningData.TabIndex = 9;
            this.label_learningData.Text = "Обучающая выборка";
            // 
            // label_testData
            // 
            this.label_testData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_testData.Location = new System.Drawing.Point(500, 475);
            this.label_testData.Name = "label_testData";
            this.label_testData.Size = new System.Drawing.Size(120, 30);
            this.label_testData.TabIndex = 10;
            this.label_testData.Text = "Тестовая выборка";
            this.label_testData.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // dataGridView_testData
            // 
            this.dataGridView_testData.AllowUserToAddRows = false;
            this.dataGridView_testData.AllowUserToDeleteRows = false;
            this.dataGridView_testData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_testData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_testData.Location = new System.Drawing.Point(15, 510);
            this.dataGridView_testData.MultiSelect = false;
            this.dataGridView_testData.Name = "dataGridView_testData";
            this.dataGridView_testData.ReadOnly = true;
            this.dataGridView_testData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_testData.Size = new System.Drawing.Size(605, 200);
            this.dataGridView_testData.TabIndex = 11;
            // 
            // label_learningCount
            // 
            this.label_learningCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_learningCount.AutoSize = true;
            this.label_learningCount.Location = new System.Drawing.Point(20, 465);
            this.label_learningCount.Name = "label_learningCount";
            this.label_learningCount.Size = new System.Drawing.Size(0, 13);
            this.label_learningCount.TabIndex = 12;
            // 
            // label_testCount
            // 
            this.label_testCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_testCount.AutoSize = true;
            this.label_testCount.Location = new System.Drawing.Point(585, 470);
            this.label_testCount.Name = "label_testCount";
            this.label_testCount.Size = new System.Drawing.Size(0, 13);
            this.label_testCount.TabIndex = 13;
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 716);
            this.Controls.Add(this.label_testCount);
            this.Controls.Add(this.label_learningCount);
            this.Controls.Add(this.dataGridView_testData);
            this.Controls.Add(this.label_testData);
            this.Controls.Add(this.label_learningData);
            this.Controls.Add(this.button_swap);
            this.Controls.Add(this.dataGridView_learningData);
            this.Controls.Add(this.panel_neurons);
            this.Controls.Add(this.tabControl);
            this.Name = "LearningForm";
            this.Text = "LearningForm";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_percent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_learningRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_learningCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_errorBarier)).EndInit();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_learningData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_testData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.Panel panel_neurons;
        public System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label_fileName;
        private System.Windows.Forms.Button button_readFile;
        public System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.NumericUpDown numericUpDown_learningCount;
        private System.Windows.Forms.NumericUpDown numericUpDown_errorBarier;
        private System.Windows.Forms.Label label_or;
        private System.Windows.Forms.RadioButton radioButton_learningCount;
        private System.Windows.Forms.RadioButton radioButton_errorBarrier;
        private System.Windows.Forms.Label label_learningRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_learningRate;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DataGridView dataGridView_learningData;
        private System.Windows.Forms.Button button_swap;
        private System.Windows.Forms.Label label_learningData;
        private System.Windows.Forms.Label label_testData;
        private System.Windows.Forms.DataGridView dataGridView_testData;
        private System.Windows.Forms.Label label_percent;
        private System.Windows.Forms.NumericUpDown numericUpDown_percent;
        private System.Windows.Forms.Label label_learningCount;
        private System.Windows.Forms.Label label_testCount;
        private System.Windows.Forms.Button button_dataset;
    }
}