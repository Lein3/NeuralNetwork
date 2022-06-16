namespace Constructor
{
    partial class DataForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Description = new System.Windows.Forms.Label();
            this.Label_Description3 = new System.Windows.Forms.LinkLabel();
            this.label_Description2 = new System.Windows.Forms.Label();
            this.label_SelectInputType = new System.Windows.Forms.Label();
            this.label_SelectInputType2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel_FromFile = new System.Windows.Forms.Panel();
            this.checkBox_FromFileSaveCheck = new System.Windows.Forms.CheckBox();
            this.textBox_FromFileSaveName = new System.Windows.Forms.TextBox();
            this.label_FromFileSave = new System.Windows.Forms.Label();
            this.radioButton_Separator2 = new System.Windows.Forms.RadioButton();
            this.radioButton_Separator1 = new System.Windows.Forms.RadioButton();
            this.label_FileSeparatorSing = new System.Windows.Forms.Label();
            this.button_FromFile = new System.Windows.Forms.Button();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.panel_FromDatabase = new System.Windows.Forms.Panel();
            this.label_DataSourceName = new System.Windows.Forms.Label();
            this.comboBox_SelectDatasetFromDataSource = new System.Windows.Forms.ComboBox();
            this.label_SelectTableFromDataSource = new System.Windows.Forms.Label();
            this.button_SelectDataSource = new System.Windows.Forms.Button();
            this.panel_FromPublicDataset = new System.Windows.Forms.Panel();
            this.comboBox_SelectPublicDataset = new System.Windows.Forms.ComboBox();
            this.label_SelectPublicDataset = new System.Windows.Forms.Label();
            this.label_DataPreview = new System.Windows.Forms.Label();
            this.label_DataPreviewInfo = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel_FromPrivateDataset = new System.Windows.Forms.Panel();
            this.comboBox_SelectPrivateDataset = new System.Windows.Forms.ComboBox();
            this.label_SelectPrivateDataset = new System.Windows.Forms.Label();
            this.button_Next = new System.Windows.Forms.Button();
            this.predictMarkControl0 = new Constructor.PredictMarkControl();
            this.panel_FromFile.SuspendLayout();
            this.panel_FromDatabase.SuspendLayout();
            this.panel_FromPublicDataset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel_FromPrivateDataset.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.ForeColor = System.Drawing.Color.White;
            this.label_Description.Location = new System.Drawing.Point(10, 10);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(247, 30);
            this.label_Description.TabIndex = 1;
            this.label_Description.Text = "Добавление данных";
            // 
            // Label_Description3
            // 
            this.Label_Description3.ActiveLinkColor = System.Drawing.Color.White;
            this.Label_Description3.AutoSize = true;
            this.Label_Description3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.Label_Description3.Location = new System.Drawing.Point(12, 70);
            this.Label_Description3.Name = "Label_Description3";
            this.Label_Description3.Size = new System.Drawing.Size(462, 17);
            this.Label_Description3.TabIndex = 5;
            this.Label_Description3.TabStop = true;
            this.Label_Description3.Text = "Как получить примеры наборов данных и дополнительные сведения?";
            // 
            // label_Description2
            // 
            this.label_Description2.AutoSize = true;
            this.label_Description2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description2.ForeColor = System.Drawing.Color.White;
            this.label_Description2.Location = new System.Drawing.Point(12, 50);
            this.label_Description2.Name = "label_Description2";
            this.label_Description2.Size = new System.Drawing.Size(623, 17);
            this.label_Description2.TabIndex = 4;
            this.label_Description2.Text = "Для создания модели необходимо добавить данные и выбрать столбец для прогнозирова" +
    "ния.\r\n";
            // 
            // label_SelectInputType
            // 
            this.label_SelectInputType.AutoSize = true;
            this.label_SelectInputType.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectInputType.ForeColor = System.Drawing.Color.White;
            this.label_SelectInputType.Location = new System.Drawing.Point(10, 120);
            this.label_SelectInputType.Name = "label_SelectInputType";
            this.label_SelectInputType.Size = new System.Drawing.Size(180, 27);
            this.label_SelectInputType.TabIndex = 6;
            this.label_SelectInputType.Text = "Входные данные";
            // 
            // label_SelectInputType2
            // 
            this.label_SelectInputType2.AutoSize = true;
            this.label_SelectInputType2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectInputType2.ForeColor = System.Drawing.Color.White;
            this.label_SelectInputType2.Location = new System.Drawing.Point(14, 155);
            this.label_SelectInputType2.Name = "label_SelectInputType2";
            this.label_SelectInputType2.Size = new System.Drawing.Size(155, 34);
            this.label_SelectInputType2.TabIndex = 7;
            this.label_SelectInputType2.Text = "Тип источника данных\r\n\r\n";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(20, 175);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(147, 20);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Файл (CSV, TSV, TXT)";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(20, 200);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 20);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "SQL Server";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(20, 225);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(212, 20);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Общедоступные наборы данных";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Enabled = false;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(20, 250);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(143, 20);
            this.radioButton4.TabIndex = 11;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Мои наборы данных";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // panel_FromFile
            // 
            this.panel_FromFile.Controls.Add(this.checkBox_FromFileSaveCheck);
            this.panel_FromFile.Controls.Add(this.textBox_FromFileSaveName);
            this.panel_FromFile.Controls.Add(this.label_FromFileSave);
            this.panel_FromFile.Controls.Add(this.radioButton_Separator2);
            this.panel_FromFile.Controls.Add(this.radioButton_Separator1);
            this.panel_FromFile.Controls.Add(this.label_FileSeparatorSing);
            this.panel_FromFile.Controls.Add(this.button_FromFile);
            this.panel_FromFile.Controls.Add(this.textBox_FilePath);
            this.panel_FromFile.Location = new System.Drawing.Point(575, 105);
            this.panel_FromFile.Name = "panel_FromFile";
            this.panel_FromFile.Size = new System.Drawing.Size(540, 115);
            this.panel_FromFile.TabIndex = 12;
            this.panel_FromFile.Visible = false;
            // 
            // checkBox_FromFileSaveCheck
            // 
            this.checkBox_FromFileSaveCheck.AutoSize = true;
            this.checkBox_FromFileSaveCheck.Checked = true;
            this.checkBox_FromFileSaveCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_FromFileSaveCheck.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.checkBox_FromFileSaveCheck.ForeColor = System.Drawing.Color.White;
            this.checkBox_FromFileSaveCheck.Location = new System.Drawing.Point(335, 86);
            this.checkBox_FromFileSaveCheck.Name = "checkBox_FromFileSaveCheck";
            this.checkBox_FromFileSaveCheck.Size = new System.Drawing.Size(144, 21);
            this.checkBox_FromFileSaveCheck.TabIndex = 38;
            this.checkBox_FromFileSaveCheck.Text = "Сохраняем в базе";
            this.checkBox_FromFileSaveCheck.UseVisualStyleBackColor = true;
            // 
            // textBox_FromFileSaveName
            // 
            this.textBox_FromFileSaveName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_FromFileSaveName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FromFileSaveName.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.textBox_FromFileSaveName.ForeColor = System.Drawing.Color.White;
            this.textBox_FromFileSaveName.Location = new System.Drawing.Point(75, 85);
            this.textBox_FromFileSaveName.Name = "textBox_FromFileSaveName";
            this.textBox_FromFileSaveName.Size = new System.Drawing.Size(244, 22);
            this.textBox_FromFileSaveName.TabIndex = 37;
            // 
            // label_FromFileSave
            // 
            this.label_FromFileSave.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FromFileSave.ForeColor = System.Drawing.Color.White;
            this.label_FromFileSave.Location = new System.Drawing.Point(20, 85);
            this.label_FromFileSave.Name = "label_FromFileSave";
            this.label_FromFileSave.Size = new System.Drawing.Size(45, 15);
            this.label_FromFileSave.TabIndex = 36;
            this.label_FromFileSave.Text = "Имя\r\n";
            // 
            // radioButton_Separator2
            // 
            this.radioButton_Separator2.AutoSize = true;
            this.radioButton_Separator2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Separator2.ForeColor = System.Drawing.Color.White;
            this.radioButton_Separator2.Location = new System.Drawing.Point(335, 55);
            this.radioButton_Separator2.Name = "radioButton_Separator2";
            this.radioButton_Separator2.Size = new System.Drawing.Size(92, 24);
            this.radioButton_Separator2.TabIndex = 35;
            this.radioButton_Separator2.Text = "Запятая";
            this.radioButton_Separator2.UseVisualStyleBackColor = true;
            this.radioButton_Separator2.CheckedChanged += new System.EventHandler(this.radioButton_Separator2_CheckedChanged);
            // 
            // radioButton_Separator1
            // 
            this.radioButton_Separator1.AutoSize = true;
            this.radioButton_Separator1.Checked = true;
            this.radioButton_Separator1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Separator1.ForeColor = System.Drawing.Color.White;
            this.radioButton_Separator1.Location = new System.Drawing.Point(170, 55);
            this.radioButton_Separator1.Name = "radioButton_Separator1";
            this.radioButton_Separator1.Size = new System.Drawing.Size(149, 24);
            this.radioButton_Separator1.TabIndex = 34;
            this.radioButton_Separator1.TabStop = true;
            this.radioButton_Separator1.Text = "Точка с запятой";
            this.radioButton_Separator1.UseVisualStyleBackColor = true;
            this.radioButton_Separator1.CheckedChanged += new System.EventHandler(this.radioButton_Separator1_CheckedChanged);
            // 
            // label_FileSeparatorSing
            // 
            this.label_FileSeparatorSing.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_FileSeparatorSing.ForeColor = System.Drawing.Color.White;
            this.label_FileSeparatorSing.Location = new System.Drawing.Point(20, 60);
            this.label_FileSeparatorSing.Name = "label_FileSeparatorSing";
            this.label_FileSeparatorSing.Size = new System.Drawing.Size(130, 15);
            this.label_FileSeparatorSing.TabIndex = 34;
            this.label_FileSeparatorSing.Text = "Знак разделитель\r\n\r\n";
            // 
            // button_FromFile
            // 
            this.button_FromFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button_FromFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_FromFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(35)))));
            this.button_FromFile.FlatAppearance.BorderSize = 0;
            this.button_FromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FromFile.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_FromFile.ForeColor = System.Drawing.Color.White;
            this.button_FromFile.Location = new System.Drawing.Point(425, 20);
            this.button_FromFile.Margin = new System.Windows.Forms.Padding(0);
            this.button_FromFile.Name = "button_FromFile";
            this.button_FromFile.Size = new System.Drawing.Size(70, 22);
            this.button_FromFile.TabIndex = 26;
            this.button_FromFile.Text = "Обзор...";
            this.button_FromFile.UseVisualStyleBackColor = false;
            this.button_FromFile.Click += new System.EventHandler(this.button_FromFile_Click);
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FilePath.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.textBox_FilePath.ForeColor = System.Drawing.Color.White;
            this.textBox_FilePath.Location = new System.Drawing.Point(15, 20);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(400, 22);
            this.textBox_FilePath.TabIndex = 0;
            // 
            // panel_FromDatabase
            // 
            this.panel_FromDatabase.Controls.Add(this.label_DataSourceName);
            this.panel_FromDatabase.Controls.Add(this.comboBox_SelectDatasetFromDataSource);
            this.panel_FromDatabase.Controls.Add(this.label_SelectTableFromDataSource);
            this.panel_FromDatabase.Controls.Add(this.button_SelectDataSource);
            this.panel_FromDatabase.Location = new System.Drawing.Point(685, 243);
            this.panel_FromDatabase.Name = "panel_FromDatabase";
            this.panel_FromDatabase.Size = new System.Drawing.Size(429, 120);
            this.panel_FromDatabase.TabIndex = 13;
            this.panel_FromDatabase.Visible = false;
            // 
            // label_DataSourceName
            // 
            this.label_DataSourceName.AutoSize = true;
            this.label_DataSourceName.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataSourceName.ForeColor = System.Drawing.Color.White;
            this.label_DataSourceName.Location = new System.Drawing.Point(215, 15);
            this.label_DataSourceName.Name = "label_DataSourceName";
            this.label_DataSourceName.Size = new System.Drawing.Size(192, 17);
            this.label_DataSourceName.TabIndex = 28;
            this.label_DataSourceName.Text = "Источник данных не выбран\r\n";
            // 
            // comboBox_SelectDatasetFromDataSource
            // 
            this.comboBox_SelectDatasetFromDataSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_SelectDatasetFromDataSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectDatasetFromDataSource.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_SelectDatasetFromDataSource.ForeColor = System.Drawing.Color.White;
            this.comboBox_SelectDatasetFromDataSource.FormattingEnabled = true;
            this.comboBox_SelectDatasetFromDataSource.Location = new System.Drawing.Point(10, 80);
            this.comboBox_SelectDatasetFromDataSource.Name = "comboBox_SelectDatasetFromDataSource";
            this.comboBox_SelectDatasetFromDataSource.Size = new System.Drawing.Size(185, 23);
            this.comboBox_SelectDatasetFromDataSource.TabIndex = 27;
            this.comboBox_SelectDatasetFromDataSource.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectDatasetsFromDataSource_SelectionChangeCommitted);
            // 
            // label_SelectTableFromDataSource
            // 
            this.label_SelectTableFromDataSource.AutoSize = true;
            this.label_SelectTableFromDataSource.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectTableFromDataSource.ForeColor = System.Drawing.Color.White;
            this.label_SelectTableFromDataSource.Location = new System.Drawing.Point(10, 50);
            this.label_SelectTableFromDataSource.Name = "label_SelectTableFromDataSource";
            this.label_SelectTableFromDataSource.Size = new System.Drawing.Size(65, 17);
            this.label_SelectTableFromDataSource.TabIndex = 15;
            this.label_SelectTableFromDataSource.Text = "Таблица\r\n";
            // 
            // button_SelectDataSource
            // 
            this.button_SelectDataSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button_SelectDataSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SelectDataSource.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(35)))));
            this.button_SelectDataSource.FlatAppearance.BorderSize = 0;
            this.button_SelectDataSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SelectDataSource.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SelectDataSource.ForeColor = System.Drawing.Color.White;
            this.button_SelectDataSource.Location = new System.Drawing.Point(10, 10);
            this.button_SelectDataSource.Margin = new System.Windows.Forms.Padding(0);
            this.button_SelectDataSource.Name = "button_SelectDataSource";
            this.button_SelectDataSource.Size = new System.Drawing.Size(186, 22);
            this.button_SelectDataSource.TabIndex = 26;
            this.button_SelectDataSource.Text = "Выбрать источник данных";
            this.button_SelectDataSource.UseVisualStyleBackColor = false;
            this.button_SelectDataSource.Click += new System.EventHandler(this.button_SelectDataSource_Click);
            // 
            // panel_FromPublicDataset
            // 
            this.panel_FromPublicDataset.Controls.Add(this.comboBox_SelectPublicDataset);
            this.panel_FromPublicDataset.Controls.Add(this.label_SelectPublicDataset);
            this.panel_FromPublicDataset.Location = new System.Drawing.Point(625, 375);
            this.panel_FromPublicDataset.Name = "panel_FromPublicDataset";
            this.panel_FromPublicDataset.Size = new System.Drawing.Size(230, 80);
            this.panel_FromPublicDataset.TabIndex = 14;
            this.panel_FromPublicDataset.Visible = false;
            // 
            // comboBox_SelectPublicDataset
            // 
            this.comboBox_SelectPublicDataset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_SelectPublicDataset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectPublicDataset.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_SelectPublicDataset.ForeColor = System.Drawing.Color.White;
            this.comboBox_SelectPublicDataset.FormattingEnabled = true;
            this.comboBox_SelectPublicDataset.Location = new System.Drawing.Point(10, 40);
            this.comboBox_SelectPublicDataset.Name = "comboBox_SelectPublicDataset";
            this.comboBox_SelectPublicDataset.Size = new System.Drawing.Size(185, 23);
            this.comboBox_SelectPublicDataset.TabIndex = 29;
            this.comboBox_SelectPublicDataset.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectDatasetFromLocalDatabase_SelectionChangeCommitted);
            // 
            // label_SelectPublicDataset
            // 
            this.label_SelectPublicDataset.AutoSize = true;
            this.label_SelectPublicDataset.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectPublicDataset.ForeColor = System.Drawing.Color.White;
            this.label_SelectPublicDataset.Location = new System.Drawing.Point(10, 10);
            this.label_SelectPublicDataset.Name = "label_SelectPublicDataset";
            this.label_SelectPublicDataset.Size = new System.Drawing.Size(100, 17);
            this.label_SelectPublicDataset.TabIndex = 28;
            this.label_SelectPublicDataset.Text = "Набор данных";
            // 
            // label_DataPreview
            // 
            this.label_DataPreview.AutoSize = true;
            this.label_DataPreview.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataPreview.ForeColor = System.Drawing.Color.White;
            this.label_DataPreview.Location = new System.Drawing.Point(15, 420);
            this.label_DataPreview.Name = "label_DataPreview";
            this.label_DataPreview.Size = new System.Drawing.Size(374, 27);
            this.label_DataPreview.TabIndex = 32;
            this.label_DataPreview.Text = "Предварительный просмотр данных";
            // 
            // label_DataPreviewInfo
            // 
            this.label_DataPreviewInfo.AutoSize = true;
            this.label_DataPreviewInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DataPreviewInfo.ForeColor = System.Drawing.Color.White;
            this.label_DataPreviewInfo.Location = new System.Drawing.Point(21, 455);
            this.label_DataPreviewInfo.Name = "label_DataPreviewInfo";
            this.label_DataPreviewInfo.Size = new System.Drawing.Size(295, 17);
            this.label_DataPreviewInfo.TabIndex = 33;
            this.label_DataPreviewInfo.Text = "Здесь отобразится сводка о наборе данных\r\n";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dataGridView.Location = new System.Drawing.Point(20, 490);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Size = new System.Drawing.Size(1016, 330);
            this.dataGridView.TabIndex = 34;
            // 
            // panel_FromPrivateDataset
            // 
            this.panel_FromPrivateDataset.Controls.Add(this.comboBox_SelectPrivateDataset);
            this.panel_FromPrivateDataset.Controls.Add(this.label_SelectPrivateDataset);
            this.panel_FromPrivateDataset.Location = new System.Drawing.Point(880, 375);
            this.panel_FromPrivateDataset.Name = "panel_FromPrivateDataset";
            this.panel_FromPrivateDataset.Size = new System.Drawing.Size(230, 80);
            this.panel_FromPrivateDataset.TabIndex = 35;
            this.panel_FromPrivateDataset.Visible = false;
            // 
            // comboBox_SelectPrivateDataset
            // 
            this.comboBox_SelectPrivateDataset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_SelectPrivateDataset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectPrivateDataset.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_SelectPrivateDataset.ForeColor = System.Drawing.Color.White;
            this.comboBox_SelectPrivateDataset.FormattingEnabled = true;
            this.comboBox_SelectPrivateDataset.Location = new System.Drawing.Point(10, 40);
            this.comboBox_SelectPrivateDataset.Name = "comboBox_SelectPrivateDataset";
            this.comboBox_SelectPrivateDataset.Size = new System.Drawing.Size(185, 23);
            this.comboBox_SelectPrivateDataset.TabIndex = 29;
            this.comboBox_SelectPrivateDataset.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectDatasetFromLocalDatabase_SelectionChangeCommitted);
            // 
            // label_SelectPrivateDataset
            // 
            this.label_SelectPrivateDataset.AutoSize = true;
            this.label_SelectPrivateDataset.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectPrivateDataset.ForeColor = System.Drawing.Color.White;
            this.label_SelectPrivateDataset.Location = new System.Drawing.Point(10, 10);
            this.label_SelectPrivateDataset.Name = "label_SelectPrivateDataset";
            this.label_SelectPrivateDataset.Size = new System.Drawing.Size(100, 17);
            this.label_SelectPrivateDataset.TabIndex = 28;
            this.label_SelectPrivateDataset.Text = "Набор данных";
            // 
            // button_Next
            // 
            this.button_Next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Next.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(35)))));
            this.button_Next.FlatAppearance.BorderSize = 0;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Next.ForeColor = System.Drawing.Color.White;
            this.button_Next.Location = new System.Drawing.Point(1051, 775);
            this.button_Next.Margin = new System.Windows.Forms.Padding(0);
            this.button_Next.Name = "button_Next";
            this.button_Next.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_Next.Size = new System.Drawing.Size(70, 45);
            this.button_Next.TabIndex = 36;
            this.button_Next.Text = "Далее";
            this.button_Next.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Visible = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // predictMarkControl0
            // 
            this.predictMarkControl0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.predictMarkControl0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.predictMarkControl0.Location = new System.Drawing.Point(15, 275);
            this.predictMarkControl0.MarkIndex = 0;
            this.predictMarkControl0.Name = "predictMarkControl0";
            this.predictMarkControl0.Size = new System.Drawing.Size(280, 130);
            this.predictMarkControl0.TabIndex = 38;
            this.predictMarkControl0.Visible = false;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1131, 840);
            this.ControlBox = false;
            this.Controls.Add(this.predictMarkControl0);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.panel_FromPrivateDataset);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label_DataPreviewInfo);
            this.Controls.Add(this.label_DataPreview);
            this.Controls.Add(this.panel_FromPublicDataset);
            this.Controls.Add(this.panel_FromDatabase);
            this.Controls.Add(this.panel_FromFile);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label_SelectInputType2);
            this.Controls.Add(this.label_SelectInputType);
            this.Controls.Add(this.Label_Description3);
            this.Controls.Add(this.label_Description2);
            this.Controls.Add(this.label_Description);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel_FromFile.ResumeLayout(false);
            this.panel_FromFile.PerformLayout();
            this.panel_FromDatabase.ResumeLayout(false);
            this.panel_FromDatabase.PerformLayout();
            this.panel_FromPublicDataset.ResumeLayout(false);
            this.panel_FromPublicDataset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel_FromPrivateDataset.ResumeLayout(false);
            this.panel_FromPrivateDataset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.LinkLabel Label_Description3;
        private System.Windows.Forms.Label label_Description2;
        private System.Windows.Forms.Label label_SelectInputType;
        private System.Windows.Forms.Label label_SelectInputType2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel_FromFile;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Button button_FromFile;
        private System.Windows.Forms.Panel panel_FromDatabase;
        private System.Windows.Forms.Button button_SelectDataSource;
        private System.Windows.Forms.Panel panel_FromPublicDataset;
        private System.Windows.Forms.ComboBox comboBox_SelectDatasetFromDataSource;
        private System.Windows.Forms.Label label_SelectTableFromDataSource;
        private System.Windows.Forms.ComboBox comboBox_SelectPublicDataset;
        private System.Windows.Forms.Label label_SelectPublicDataset;
        private System.Windows.Forms.Label label_DataSourceName;
        private System.Windows.Forms.Label label_DataPreview;
        private System.Windows.Forms.Label label_DataPreviewInfo;
        private System.Windows.Forms.Label label_FileSeparatorSing;
        private System.Windows.Forms.RadioButton radioButton_Separator2;
        private System.Windows.Forms.RadioButton radioButton_Separator1;
        private System.Windows.Forms.Panel panel_FromPrivateDataset;
        private System.Windows.Forms.ComboBox comboBox_SelectPrivateDataset;
        private System.Windows.Forms.Label label_SelectPrivateDataset;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.CheckBox checkBox_FromFileSaveCheck;
        private System.Windows.Forms.TextBox textBox_FromFileSaveName;
        private System.Windows.Forms.Label label_FromFileSave;
        public System.Windows.Forms.DataGridView dataGridView;
        private PredictMarkControl predictMarkControl0;
    }
}