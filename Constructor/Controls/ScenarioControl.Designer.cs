namespace Constructor
{
    partial class ScenarioControl
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
            this.panel_Main = new System.Windows.Forms.Panel();
            this.label_ScenarioName = new System.Windows.Forms.Label();
            this.pictureBox_Image = new System.Windows.Forms.PictureBox();
            this.label_ScenarioDescription = new System.Windows.Forms.Label();
            this.panel_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Main
            // 
            this.panel_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel_Main.Controls.Add(this.label_ScenarioName);
            this.panel_Main.Controls.Add(this.pictureBox_Image);
            this.panel_Main.Controls.Add(this.label_ScenarioDescription);
            this.panel_Main.Location = new System.Drawing.Point(3, 5);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(214, 295);
            this.panel_Main.TabIndex = 0;
            // 
            // label_ScenarioName
            // 
            this.label_ScenarioName.BackColor = System.Drawing.Color.Transparent;
            this.label_ScenarioName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_ScenarioName.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ScenarioName.ForeColor = System.Drawing.Color.White;
            this.label_ScenarioName.Location = new System.Drawing.Point(0, 143);
            this.label_ScenarioName.Name = "label_ScenarioName";
            this.label_ScenarioName.Padding = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.label_ScenarioName.Size = new System.Drawing.Size(214, 57);
            this.label_ScenarioName.TabIndex = 1;
            this.label_ScenarioName.Text = "Название сценария";
            // 
            // pictureBox_Image
            // 
            this.pictureBox_Image.Image = global::Constructor.Properties.Resources.мегамозг;
            this.pictureBox_Image.Location = new System.Drawing.Point(0, 10);
            this.pictureBox_Image.Name = "pictureBox_Image";
            this.pictureBox_Image.Size = new System.Drawing.Size(214, 110);
            this.pictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Image.TabIndex = 0;
            this.pictureBox_Image.TabStop = false;
            // 
            // label_ScenarioDescription
            // 
            this.label_ScenarioDescription.BackColor = System.Drawing.Color.Transparent;
            this.label_ScenarioDescription.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_ScenarioDescription.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ScenarioDescription.ForeColor = System.Drawing.Color.White;
            this.label_ScenarioDescription.Location = new System.Drawing.Point(0, 200);
            this.label_ScenarioDescription.Name = "label_ScenarioDescription";
            this.label_ScenarioDescription.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label_ScenarioDescription.Size = new System.Drawing.Size(214, 95);
            this.label_ScenarioDescription.TabIndex = 2;
            this.label_ScenarioDescription.Text = "Описание сценария";
            // 
            // ScenarioControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.Controls.Add(this.panel_Main);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximumSize = new System.Drawing.Size(220, 300);
            this.MinimumSize = new System.Drawing.Size(220, 300);
            this.Name = "ScenarioControl";
            this.Size = new System.Drawing.Size(220, 300);
            this.panel_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Main;
        public System.Windows.Forms.PictureBox pictureBox_Image;
        private System.Windows.Forms.Label label_ScenarioDescription;
        public System.Windows.Forms.Label label_ScenarioName;
    }
}
