namespace Constructor
{
    partial class UserDatasetControl
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
            this.label_Name = new System.Windows.Forms.Label();
            this.label_CreationDate = new System.Windows.Forms.Label();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_Replace = new System.Windows.Forms.Button();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(10, 10);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(97, 24);
            this.label_Name.TabIndex = 2;
            this.label_Name.Text = "Название";
            // 
            // label_CreationDate
            // 
            this.label_CreationDate.AutoSize = true;
            this.label_CreationDate.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CreationDate.ForeColor = System.Drawing.Color.White;
            this.label_CreationDate.Location = new System.Drawing.Point(10, 45);
            this.label_CreationDate.Name = "label_CreationDate";
            this.label_CreationDate.Size = new System.Drawing.Size(124, 20);
            this.label_CreationDate.TabIndex = 3;
            this.label_CreationDate.Text = "Дата создания";
            // 
            // label_Info
            // 
            this.label_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Info.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Info.ForeColor = System.Drawing.Color.White;
            this.label_Info.Location = new System.Drawing.Point(10, 80);
            this.label_Info.Name = "label_Info";
            this.label_Info.Size = new System.Drawing.Size(660, 50);
            this.label_Info.TabIndex = 4;
            this.label_Info.Text = "Описание";
            // 
            // button_Replace
            // 
            this.button_Replace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Replace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Replace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Replace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(35)))));
            this.button_Replace.FlatAppearance.BorderSize = 0;
            this.button_Replace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Replace.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Replace.ForeColor = System.Drawing.Color.White;
            this.button_Replace.Location = new System.Drawing.Point(620, 30);
            this.button_Replace.Margin = new System.Windows.Forms.Padding(0);
            this.button_Replace.MaximumSize = new System.Drawing.Size(50, 50);
            this.button_Replace.MinimumSize = new System.Drawing.Size(50, 50);
            this.button_Replace.Name = "button_Replace";
            this.button_Replace.Size = new System.Drawing.Size(50, 50);
            this.button_Replace.TabIndex = 5;
            this.button_Replace.Text = "▼";
            this.button_Replace.UseVisualStyleBackColor = false;
            this.button_Replace.Click += new System.EventHandler(this.button_Replace_Click);
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel_Top.Controls.Add(this.button_Replace);
            this.panel_Top.Controls.Add(this.label_Info);
            this.panel_Top.Controls.Add(this.label_CreationDate);
            this.panel_Top.Controls.Add(this.label_Name);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(700, 140);
            this.panel_Top.TabIndex = 27;
            // 
            // UserDatasetControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.panel_Top);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.MinimumSize = new System.Drawing.Size(2, 140);
            this.Name = "UserDatasetControl";
            this.Size = new System.Drawing.Size(700, 140);
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_CreationDate;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button button_Replace;
        private System.Windows.Forms.Panel panel_Top;
    }
}
