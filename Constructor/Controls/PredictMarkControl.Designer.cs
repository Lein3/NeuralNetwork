namespace Constructor
{
    partial class PredictMarkControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_RemoveMark = new System.Windows.Forms.Button();
            this.textBox_PredictMarkName = new System.Windows.Forms.TextBox();
            this.label_PredictMarkName = new System.Windows.Forms.Label();
            this.button_AddMark = new System.Windows.Forms.Button();
            this.pictureBox_PredictMarkHelp = new System.Windows.Forms.PictureBox();
            this.comboBox_PredictMark = new System.Windows.Forms.ComboBox();
            this.label_PredictMark = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PredictMarkHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // button_RemoveMark
            // 
            this.button_RemoveMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_RemoveMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_RemoveMark.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_RemoveMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveMark.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveMark.ForeColor = System.Drawing.Color.White;
            this.button_RemoveMark.Location = new System.Drawing.Point(245, 40);
            this.button_RemoveMark.Margin = new System.Windows.Forms.Padding(0);
            this.button_RemoveMark.Name = "button_RemoveMark";
            this.button_RemoveMark.Size = new System.Drawing.Size(20, 25);
            this.button_RemoveMark.TabIndex = 50;
            this.button_RemoveMark.Text = "-";
            this.button_RemoveMark.UseVisualStyleBackColor = false;
            this.button_RemoveMark.Click += new System.EventHandler(this.button_RemoveMark_Click);
            // 
            // textBox_PredictMarkName
            // 
            this.textBox_PredictMarkName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_PredictMarkName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_PredictMarkName.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.textBox_PredictMarkName.ForeColor = System.Drawing.Color.White;
            this.textBox_PredictMarkName.Location = new System.Drawing.Point(10, 95);
            this.textBox_PredictMarkName.Name = "textBox_PredictMarkName";
            this.textBox_PredictMarkName.Size = new System.Drawing.Size(187, 22);
            this.textBox_PredictMarkName.TabIndex = 49;
            // 
            // label_PredictMarkName
            // 
            this.label_PredictMarkName.AutoSize = true;
            this.label_PredictMarkName.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PredictMarkName.ForeColor = System.Drawing.Color.White;
            this.label_PredictMarkName.Location = new System.Drawing.Point(5, 75);
            this.label_PredictMarkName.Name = "label_PredictMarkName";
            this.label_PredictMarkName.Size = new System.Drawing.Size(124, 17);
            this.label_PredictMarkName.TabIndex = 48;
            this.label_PredictMarkName.Text = "Псевдоним метки\r\n";
            // 
            // button_AddMark
            // 
            this.button_AddMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_AddMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddMark.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_AddMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddMark.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddMark.ForeColor = System.Drawing.Color.White;
            this.button_AddMark.Location = new System.Drawing.Point(214, 40);
            this.button_AddMark.Margin = new System.Windows.Forms.Padding(0);
            this.button_AddMark.Name = "button_AddMark";
            this.button_AddMark.Size = new System.Drawing.Size(20, 25);
            this.button_AddMark.TabIndex = 47;
            this.button_AddMark.Text = "+";
            this.button_AddMark.UseVisualStyleBackColor = false;
            this.button_AddMark.Click += new System.EventHandler(this.button_AddMark_Click);
            // 
            // pictureBox_PredictMarkHelp
            // 
            this.pictureBox_PredictMarkHelp.Image = global::Constructor.Properties.Resources.иконка_справки;
            this.pictureBox_PredictMarkHelp.Location = new System.Drawing.Point(233, 10);
            this.pictureBox_PredictMarkHelp.Name = "pictureBox_PredictMarkHelp";
            this.pictureBox_PredictMarkHelp.Size = new System.Drawing.Size(15, 15);
            this.pictureBox_PredictMarkHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_PredictMarkHelp.TabIndex = 46;
            this.pictureBox_PredictMarkHelp.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox_PredictMarkHelp, "Это целевой столбец, который должна спрогнозировать модель.");
            // 
            // comboBox_PredictMark
            // 
            this.comboBox_PredictMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_PredictMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_PredictMark.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_PredictMark.ForeColor = System.Drawing.Color.White;
            this.comboBox_PredictMark.FormattingEnabled = true;
            this.comboBox_PredictMark.Location = new System.Drawing.Point(10, 40);
            this.comboBox_PredictMark.Name = "comboBox_PredictMark";
            this.comboBox_PredictMark.Size = new System.Drawing.Size(185, 23);
            this.comboBox_PredictMark.TabIndex = 45;
            this.comboBox_PredictMark.Text = "Выберите столбец";
            this.comboBox_PredictMark.SelectionChangeCommitted += new System.EventHandler(this.comboBox_PredictMark_SelectionChangeCommitted);
            // 
            // label_PredictMark
            // 
            this.label_PredictMark.AutoSize = true;
            this.label_PredictMark.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PredictMark.ForeColor = System.Drawing.Color.White;
            this.label_PredictMark.Location = new System.Drawing.Point(5, 10);
            this.label_PredictMark.Name = "label_PredictMark";
            this.label_PredictMark.Size = new System.Drawing.Size(229, 17);
            this.label_PredictMark.TabIndex = 44;
            this.label_PredictMark.Text = "Прогнозируемый столбец(метка):\r\n";
            // 
            // PredictMarkControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.button_RemoveMark);
            this.Controls.Add(this.textBox_PredictMarkName);
            this.Controls.Add(this.label_PredictMarkName);
            this.Controls.Add(this.button_AddMark);
            this.Controls.Add(this.pictureBox_PredictMarkHelp);
            this.Controls.Add(this.comboBox_PredictMark);
            this.Controls.Add(this.label_PredictMark);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Name = "PredictMarkControl";
            this.Size = new System.Drawing.Size(280, 130);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PredictMarkHelp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_PredictMarkName;
        private System.Windows.Forms.PictureBox pictureBox_PredictMarkHelp;
        private System.Windows.Forms.Label label_PredictMark;
        public System.Windows.Forms.Button button_RemoveMark;
        public System.Windows.Forms.TextBox textBox_PredictMarkName;
        public System.Windows.Forms.Button button_AddMark;
        public System.Windows.Forms.ComboBox comboBox_PredictMark;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
