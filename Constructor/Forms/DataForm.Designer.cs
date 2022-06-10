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
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel_FromFile = new System.Windows.Forms.Panel();
            this.textBox_FilePath = new System.Windows.Forms.TextBox();
            this.button_MyModels = new System.Windows.Forms.Button();
            this.panel_FromDatabase = new System.Windows.Forms.Panel();
            this.button_SelectDataSource = new System.Windows.Forms.Button();
            this.panel_FromDataset = new System.Windows.Forms.Panel();
            this.label_SelectTable = new System.Windows.Forms.Label();
            this.comboBox_SelectTableFromDb = new System.Windows.Forms.ComboBox();
            this.comboBox_SelectDataset = new System.Windows.Forms.ComboBox();
            this.label_SelectDataset = new System.Windows.Forms.Label();
            this.label_DatabaseName = new System.Windows.Forms.Label();
            this.panel_FromFile.SuspendLayout();
            this.panel_FromDatabase.SuspendLayout();
            this.panel_FromDataset.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавление данных";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.linkLabel1.Location = new System.Drawing.Point(12, 70);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(462, 17);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Как получить примеры наборов данных и дополнительные сведения?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(623, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Для создания модели необходимо добавить данные и выбрать столбец для прогнозирова" +
    "ния.\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Входные данные";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип источника данных\r\n\r\n";
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
            // 
            // panel_FromFile
            // 
            this.panel_FromFile.Controls.Add(this.button_MyModels);
            this.panel_FromFile.Controls.Add(this.textBox_FilePath);
            this.panel_FromFile.Location = new System.Drawing.Point(425, 120);
            this.panel_FromFile.Name = "panel_FromFile";
            this.panel_FromFile.Size = new System.Drawing.Size(540, 70);
            this.panel_FromFile.TabIndex = 12;
            this.panel_FromFile.Visible = false;
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_FilePath.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.textBox_FilePath.ForeColor = System.Drawing.Color.White;
            this.textBox_FilePath.Location = new System.Drawing.Point(15, 25);
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.Size = new System.Drawing.Size(400, 22);
            this.textBox_FilePath.TabIndex = 0;
            // 
            // button_MyModels
            // 
            this.button_MyModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.button_MyModels.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_MyModels.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(35)))));
            this.button_MyModels.FlatAppearance.BorderSize = 0;
            this.button_MyModels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MyModels.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MyModels.ForeColor = System.Drawing.Color.White;
            this.button_MyModels.Location = new System.Drawing.Point(425, 25);
            this.button_MyModels.Margin = new System.Windows.Forms.Padding(0);
            this.button_MyModels.Name = "button_MyModels";
            this.button_MyModels.Size = new System.Drawing.Size(70, 22);
            this.button_MyModels.TabIndex = 26;
            this.button_MyModels.Text = "Обзор...";
            this.button_MyModels.UseVisualStyleBackColor = false;
            this.button_MyModels.Click += new System.EventHandler(this.button_MyModels_Click);
            // 
            // panel_FromDatabase
            // 
            this.panel_FromDatabase.Controls.Add(this.label_DatabaseName);
            this.panel_FromDatabase.Controls.Add(this.comboBox_SelectTableFromDb);
            this.panel_FromDatabase.Controls.Add(this.label_SelectTable);
            this.panel_FromDatabase.Controls.Add(this.button_SelectDataSource);
            this.panel_FromDatabase.Location = new System.Drawing.Point(425, 200);
            this.panel_FromDatabase.Name = "panel_FromDatabase";
            this.panel_FromDatabase.Size = new System.Drawing.Size(540, 120);
            this.panel_FromDatabase.TabIndex = 13;
            this.panel_FromDatabase.Visible = false;
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
            this.button_SelectDataSource.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_FromDataset
            // 
            this.panel_FromDataset.Controls.Add(this.comboBox_SelectDataset);
            this.panel_FromDataset.Controls.Add(this.label_SelectDataset);
            this.panel_FromDataset.Location = new System.Drawing.Point(425, 340);
            this.panel_FromDataset.Name = "panel_FromDataset";
            this.panel_FromDataset.Size = new System.Drawing.Size(540, 80);
            this.panel_FromDataset.TabIndex = 14;
            this.panel_FromDataset.Visible = false;
            // 
            // label_SelectTable
            // 
            this.label_SelectTable.AutoSize = true;
            this.label_SelectTable.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectTable.ForeColor = System.Drawing.Color.White;
            this.label_SelectTable.Location = new System.Drawing.Point(10, 50);
            this.label_SelectTable.Name = "label_SelectTable";
            this.label_SelectTable.Size = new System.Drawing.Size(65, 17);
            this.label_SelectTable.TabIndex = 15;
            this.label_SelectTable.Text = "Таблица\r\n";
            // 
            // comboBox_SelectTableFromDb
            // 
            this.comboBox_SelectTableFromDb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_SelectTableFromDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectTableFromDb.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_SelectTableFromDb.ForeColor = System.Drawing.Color.White;
            this.comboBox_SelectTableFromDb.FormattingEnabled = true;
            this.comboBox_SelectTableFromDb.Location = new System.Drawing.Point(10, 80);
            this.comboBox_SelectTableFromDb.Name = "comboBox_SelectTableFromDb";
            this.comboBox_SelectTableFromDb.Size = new System.Drawing.Size(185, 23);
            this.comboBox_SelectTableFromDb.TabIndex = 27;
            // 
            // comboBox_SelectDataset
            // 
            this.comboBox_SelectDataset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_SelectDataset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectDataset.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_SelectDataset.ForeColor = System.Drawing.Color.White;
            this.comboBox_SelectDataset.FormattingEnabled = true;
            this.comboBox_SelectDataset.Items.AddRange(new object[] {
            "база1",
            "база2",
            "база3",
            "база4"});
            this.comboBox_SelectDataset.Location = new System.Drawing.Point(10, 40);
            this.comboBox_SelectDataset.Name = "comboBox_SelectDataset";
            this.comboBox_SelectDataset.Size = new System.Drawing.Size(185, 23);
            this.comboBox_SelectDataset.TabIndex = 29;
            // 
            // label_SelectDataset
            // 
            this.label_SelectDataset.AutoSize = true;
            this.label_SelectDataset.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectDataset.ForeColor = System.Drawing.Color.White;
            this.label_SelectDataset.Location = new System.Drawing.Point(10, 10);
            this.label_SelectDataset.Name = "label_SelectDataset";
            this.label_SelectDataset.Size = new System.Drawing.Size(100, 17);
            this.label_SelectDataset.TabIndex = 28;
            this.label_SelectDataset.Text = "Набор данных";
            // 
            // label_DatabaseName
            // 
            this.label_DatabaseName.AutoSize = true;
            this.label_DatabaseName.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DatabaseName.ForeColor = System.Drawing.Color.White;
            this.label_DatabaseName.Location = new System.Drawing.Point(217, 15);
            this.label_DatabaseName.Name = "label_DatabaseName";
            this.label_DatabaseName.Size = new System.Drawing.Size(192, 17);
            this.label_DatabaseName.TabIndex = 28;
            this.label_DatabaseName.Text = "Источник данных не выбран\r\n";
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.ControlBox = false;
            this.Controls.Add(this.panel_FromDataset);
            this.Controls.Add(this.panel_FromDatabase);
            this.Controls.Add(this.panel_FromFile);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ОооКонструктор";
            this.panel_FromFile.ResumeLayout(false);
            this.panel_FromFile.PerformLayout();
            this.panel_FromDatabase.ResumeLayout(false);
            this.panel_FromDatabase.PerformLayout();
            this.panel_FromDataset.ResumeLayout(false);
            this.panel_FromDataset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel_FromFile;
        private System.Windows.Forms.TextBox textBox_FilePath;
        private System.Windows.Forms.Button button_MyModels;
        private System.Windows.Forms.Panel panel_FromDatabase;
        private System.Windows.Forms.Button button_SelectDataSource;
        private System.Windows.Forms.Panel panel_FromDataset;
        private System.Windows.Forms.ComboBox comboBox_SelectTableFromDb;
        private System.Windows.Forms.Label label_SelectTable;
        private System.Windows.Forms.ComboBox comboBox_SelectDataset;
        private System.Windows.Forms.Label label_SelectDataset;
        private System.Windows.Forms.Label label_DatabaseName;
    }
}