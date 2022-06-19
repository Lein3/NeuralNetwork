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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Description = new System.Windows.Forms.Label();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.button_StartLearning = new System.Windows.Forms.Button();
            this.numericUpDown_TestPercent = new System.Windows.Forms.NumericUpDown();
            this.label_TestPercent = new System.Windows.Forms.Label();
            this.numericUpDown_EpochCount = new System.Windows.Forms.NumericUpDown();
            this.label_CostFunction = new System.Windows.Forms.Label();
            this.comboBox_SelectCostFunction = new System.Windows.Forms.ComboBox();
            this.numericUpDown_ErrorLimit = new System.Windows.Forms.NumericUpDown();
            this.radioButton_EpochCount = new System.Windows.Forms.RadioButton();
            this.radioButton_ErrorLimit = new System.Windows.Forms.RadioButton();
            this.numericUpDown_LearningRate = new System.Windows.Forms.NumericUpDown();
            this.label_LearningRate = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Test = new System.Windows.Forms.DataGridView();
            this.dataGridView_Learning = new System.Windows.Forms.DataGridView();
            this.label_Learning = new System.Windows.Forms.Label();
            this.panel_TestDescription = new System.Windows.Forms.Panel();
            this.label_Test = new System.Windows.Forms.Label();
            this.button_Replace = new System.Windows.Forms.Button();
            this.label_Statistcs = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TestPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EpochCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ErrorLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LearningRate)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learning)).BeginInit();
            this.panel_TestDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.ForeColor = System.Drawing.Color.White;
            this.label_Description.Location = new System.Drawing.Point(10, 5);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(129, 30);
            this.label_Description.TabIndex = 1;
            this.label_Description.Text = "Обучение";
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label_Statistcs);
            this.panel_Top.Controls.Add(this.button_StartLearning);
            this.panel_Top.Controls.Add(this.numericUpDown_TestPercent);
            this.panel_Top.Controls.Add(this.label_TestPercent);
            this.panel_Top.Controls.Add(this.numericUpDown_EpochCount);
            this.panel_Top.Controls.Add(this.label_CostFunction);
            this.panel_Top.Controls.Add(this.comboBox_SelectCostFunction);
            this.panel_Top.Controls.Add(this.numericUpDown_ErrorLimit);
            this.panel_Top.Controls.Add(this.radioButton_EpochCount);
            this.panel_Top.Controls.Add(this.radioButton_ErrorLimit);
            this.panel_Top.Controls.Add(this.numericUpDown_LearningRate);
            this.panel_Top.Controls.Add(this.label_LearningRate);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(1040, 120);
            this.panel_Top.TabIndex = 2;
            // 
            // button_StartLearning
            // 
            this.button_StartLearning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_StartLearning.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_StartLearning.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(35)))));
            this.button_StartLearning.FlatAppearance.BorderSize = 0;
            this.button_StartLearning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_StartLearning.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartLearning.ForeColor = System.Drawing.Color.White;
            this.button_StartLearning.Location = new System.Drawing.Point(805, 49);
            this.button_StartLearning.Margin = new System.Windows.Forms.Padding(0);
            this.button_StartLearning.Name = "button_StartLearning";
            this.button_StartLearning.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_StartLearning.Size = new System.Drawing.Size(152, 45);
            this.button_StartLearning.TabIndex = 57;
            this.button_StartLearning.Text = "Начать обучение";
            this.button_StartLearning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_StartLearning.UseVisualStyleBackColor = false;
            this.button_StartLearning.Click += new System.EventHandler(this.button_StartLearning_Click);
            // 
            // numericUpDown_TestPercent
            // 
            this.numericUpDown_TestPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_TestPercent.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_TestPercent.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_TestPercent.Location = new System.Drawing.Point(675, 60);
            this.numericUpDown_TestPercent.Name = "numericUpDown_TestPercent";
            this.numericUpDown_TestPercent.Size = new System.Drawing.Size(110, 22);
            this.numericUpDown_TestPercent.TabIndex = 56;
            this.numericUpDown_TestPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_TestPercent.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_TestPercent.ValueChanged += new System.EventHandler(this.numericUpDown_TestPercent_ValueChanged);
            // 
            // label_TestPercent
            // 
            this.label_TestPercent.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TestPercent.ForeColor = System.Drawing.Color.White;
            this.label_TestPercent.Location = new System.Drawing.Point(665, 20);
            this.label_TestPercent.Name = "label_TestPercent";
            this.label_TestPercent.Size = new System.Drawing.Size(125, 36);
            this.label_TestPercent.TabIndex = 55;
            this.label_TestPercent.Text = "Процент тестовой выборки";
            this.label_TestPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_EpochCount
            // 
            this.numericUpDown_EpochCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_EpochCount.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_EpochCount.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_EpochCount.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_EpochCount.Location = new System.Drawing.Point(365, 60);
            this.numericUpDown_EpochCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_EpochCount.Name = "numericUpDown_EpochCount";
            this.numericUpDown_EpochCount.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_EpochCount.TabIndex = 54;
            this.numericUpDown_EpochCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_EpochCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_EpochCount.ValueChanged += new System.EventHandler(this.numericUpDown_EpochCount_ValueChanged);
            // 
            // label_CostFunction
            // 
            this.label_CostFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_CostFunction.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CostFunction.ForeColor = System.Drawing.Color.White;
            this.label_CostFunction.Location = new System.Drawing.Point(15, 40);
            this.label_CostFunction.Name = "label_CostFunction";
            this.label_CostFunction.Size = new System.Drawing.Size(121, 20);
            this.label_CostFunction.TabIndex = 53;
            this.label_CostFunction.Text = "Функция ошибки";
            // 
            // comboBox_SelectCostFunction
            // 
            this.comboBox_SelectCostFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.comboBox_SelectCostFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectCostFunction.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_SelectCostFunction.ForeColor = System.Drawing.Color.White;
            this.comboBox_SelectCostFunction.FormattingEnabled = true;
            this.comboBox_SelectCostFunction.Location = new System.Drawing.Point(15, 60);
            this.comboBox_SelectCostFunction.Name = "comboBox_SelectCostFunction";
            this.comboBox_SelectCostFunction.Size = new System.Drawing.Size(155, 23);
            this.comboBox_SelectCostFunction.TabIndex = 52;
            this.comboBox_SelectCostFunction.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectCostFunction_SelectionChangeCommitted);
            // 
            // numericUpDown_ErrorLimit
            // 
            this.numericUpDown_ErrorLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_ErrorLimit.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_ErrorLimit.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_ErrorLimit.Location = new System.Drawing.Point(210, 60);
            this.numericUpDown_ErrorLimit.Name = "numericUpDown_ErrorLimit";
            this.numericUpDown_ErrorLimit.Size = new System.Drawing.Size(110, 22);
            this.numericUpDown_ErrorLimit.TabIndex = 48;
            this.numericUpDown_ErrorLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_ErrorLimit.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_ErrorLimit.ValueChanged += new System.EventHandler(this.numericUpDown_ErrorLimit_ValueChanged);
            // 
            // radioButton_EpochCount
            // 
            this.radioButton_EpochCount.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_EpochCount.ForeColor = System.Drawing.Color.White;
            this.radioButton_EpochCount.Location = new System.Drawing.Point(365, 35);
            this.radioButton_EpochCount.Name = "radioButton_EpochCount";
            this.radioButton_EpochCount.Size = new System.Drawing.Size(130, 20);
            this.radioButton_EpochCount.TabIndex = 47;
            this.radioButton_EpochCount.TabStop = true;
            this.radioButton_EpochCount.Text = "Количество эпох";
            this.radioButton_EpochCount.UseVisualStyleBackColor = true;
            // 
            // radioButton_ErrorLimit
            // 
            this.radioButton_ErrorLimit.Checked = true;
            this.radioButton_ErrorLimit.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_ErrorLimit.ForeColor = System.Drawing.Color.White;
            this.radioButton_ErrorLimit.Location = new System.Drawing.Point(205, 35);
            this.radioButton_ErrorLimit.Name = "radioButton_ErrorLimit";
            this.radioButton_ErrorLimit.Size = new System.Drawing.Size(134, 20);
            this.radioButton_ErrorLimit.TabIndex = 46;
            this.radioButton_ErrorLimit.TabStop = true;
            this.radioButton_ErrorLimit.Text = "Порог ошибки, в %";
            this.radioButton_ErrorLimit.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_LearningRate
            // 
            this.numericUpDown_LearningRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_LearningRate.DecimalPlaces = 2;
            this.numericUpDown_LearningRate.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_LearningRate.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_LearningRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_LearningRate.Location = new System.Drawing.Point(525, 60);
            this.numericUpDown_LearningRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_LearningRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown_LearningRate.Name = "numericUpDown_LearningRate";
            this.numericUpDown_LearningRate.Size = new System.Drawing.Size(110, 22);
            this.numericUpDown_LearningRate.TabIndex = 45;
            this.numericUpDown_LearningRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_LearningRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.numericUpDown_LearningRate.ValueChanged += new System.EventHandler(this.numericUpDown_LearningRate_ValueChanged);
            // 
            // label_LearningRate
            // 
            this.label_LearningRate.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LearningRate.ForeColor = System.Drawing.Color.White;
            this.label_LearningRate.Location = new System.Drawing.Point(522, 35);
            this.label_LearningRate.Name = "label_LearningRate";
            this.label_LearningRate.Size = new System.Drawing.Size(125, 20);
            this.label_LearningRate.TabIndex = 44;
            this.label_LearningRate.Text = "Скорость обучения\r\n";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dataGridView_Test, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.dataGridView_Learning, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label_Learning, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel_TestDescription, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1040, 480);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // dataGridView_Test
            // 
            this.dataGridView_Test.AllowUserToAddRows = false;
            this.dataGridView_Test.AllowUserToDeleteRows = false;
            this.dataGridView_Test.AllowUserToOrderColumns = true;
            this.dataGridView_Test.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView_Test.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Test.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Test.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView_Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Test.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView_Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Test.EnableHeadersVisualStyles = false;
            this.dataGridView_Test.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dataGridView_Test.Location = new System.Drawing.Point(3, 283);
            this.dataGridView_Test.Name = "dataGridView_Test";
            this.dataGridView_Test.ReadOnly = true;
            this.dataGridView_Test.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Test.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView_Test.RowHeadersVisible = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Test.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView_Test.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Test.Size = new System.Drawing.Size(1034, 194);
            this.dataGridView_Test.TabIndex = 56;
            this.dataGridView_Test.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Test_CellClick);
            // 
            // dataGridView_Learning
            // 
            this.dataGridView_Learning.AllowUserToAddRows = false;
            this.dataGridView_Learning.AllowUserToDeleteRows = false;
            this.dataGridView_Learning.AllowUserToOrderColumns = true;
            this.dataGridView_Learning.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView_Learning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Learning.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Learning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView_Learning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Learning.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView_Learning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Learning.EnableHeadersVisualStyles = false;
            this.dataGridView_Learning.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dataGridView_Learning.Location = new System.Drawing.Point(3, 28);
            this.dataGridView_Learning.Name = "dataGridView_Learning";
            this.dataGridView_Learning.ReadOnly = true;
            this.dataGridView_Learning.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Learning.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView_Learning.RowHeadersVisible = false;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Learning.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView_Learning.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Learning.Size = new System.Drawing.Size(1034, 193);
            this.dataGridView_Learning.TabIndex = 55;
            this.dataGridView_Learning.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Learning_CellClick);
            // 
            // label_Learning
            // 
            this.label_Learning.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Learning.ForeColor = System.Drawing.Color.White;
            this.label_Learning.Location = new System.Drawing.Point(3, 0);
            this.label_Learning.Name = "label_Learning";
            this.label_Learning.Size = new System.Drawing.Size(400, 25);
            this.label_Learning.TabIndex = 53;
            this.label_Learning.Text = "Обучающая выборка";
            // 
            // panel_TestDescription
            // 
            this.panel_TestDescription.Controls.Add(this.label_Test);
            this.panel_TestDescription.Controls.Add(this.button_Replace);
            this.panel_TestDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TestDescription.Location = new System.Drawing.Point(3, 227);
            this.panel_TestDescription.Name = "panel_TestDescription";
            this.panel_TestDescription.Size = new System.Drawing.Size(1034, 50);
            this.panel_TestDescription.TabIndex = 57;
            // 
            // label_Test
            // 
            this.label_Test.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Test.ForeColor = System.Drawing.Color.White;
            this.label_Test.Location = new System.Drawing.Point(3, 24);
            this.label_Test.Name = "label_Test";
            this.label_Test.Size = new System.Drawing.Size(400, 25);
            this.label_Test.TabIndex = 54;
            this.label_Test.Text = "Тестовая выборка";
            // 
            // button_Replace
            // 
            this.button_Replace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Replace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Replace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Replace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(35)))));
            this.button_Replace.FlatAppearance.BorderSize = 0;
            this.button_Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Replace.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Replace.ForeColor = System.Drawing.Color.White;
            this.button_Replace.Location = new System.Drawing.Point(483, 0);
            this.button_Replace.Margin = new System.Windows.Forms.Padding(0);
            this.button_Replace.MaximumSize = new System.Drawing.Size(50, 50);
            this.button_Replace.MinimumSize = new System.Drawing.Size(50, 50);
            this.button_Replace.Name = "button_Replace";
            this.button_Replace.Size = new System.Drawing.Size(50, 50);
            this.button_Replace.TabIndex = 3;
            this.button_Replace.Text = "▲\r\n▼";
            this.button_Replace.UseVisualStyleBackColor = false;
            this.button_Replace.Click += new System.EventHandler(this.button_Replace_Click);
            // 
            // label_Statistcs
            // 
            this.label_Statistcs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Statistcs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Statistcs.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Statistcs.ForeColor = System.Drawing.Color.White;
            this.label_Statistcs.Location = new System.Drawing.Point(965, 20);
            this.label_Statistcs.Name = "label_Statistcs";
            this.label_Statistcs.Size = new System.Drawing.Size(70, 70);
            this.label_Statistcs.TabIndex = 58;
            this.label_Statistcs.Text = "Здесь будет отображаться процесс обучения";
            // 
            // LearningForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1040, 600);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.label_Description);
            this.Controls.Add(this.panel_Top);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LearningForm";
            this.panel_Top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TestPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_EpochCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_ErrorLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LearningRate)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learning)).EndInit();
            this.panel_TestDescription.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.NumericUpDown numericUpDown_LearningRate;
        private System.Windows.Forms.Label label_LearningRate;
        private System.Windows.Forms.NumericUpDown numericUpDown_ErrorLimit;
        private System.Windows.Forms.RadioButton radioButton_EpochCount;
        private System.Windows.Forms.RadioButton radioButton_ErrorLimit;
        private System.Windows.Forms.ComboBox comboBox_SelectCostFunction;
        private System.Windows.Forms.Label label_Learning;
        private System.Windows.Forms.DataGridView dataGridView_Test;
        private System.Windows.Forms.DataGridView dataGridView_Learning;
        private System.Windows.Forms.Panel panel_TestDescription;
        private System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.Button button_Replace;
        private System.Windows.Forms.Label label_CostFunction;
        private System.Windows.Forms.NumericUpDown numericUpDown_EpochCount;
        private System.Windows.Forms.NumericUpDown numericUpDown_TestPercent;
        private System.Windows.Forms.Label label_TestPercent;
        private System.Windows.Forms.Button button_StartLearning;
        private System.Windows.Forms.Label label_Statistcs;
    }
}