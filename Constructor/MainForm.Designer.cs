namespace Constructor
{
    partial class MainForm
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
            this.currentNeuronControl1 = new Constructor.CurrentNeuronControl();
            this.SuspendLayout();
            // 
            // currentNeuronControl1
            // 
            this.currentNeuronControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currentNeuronControl1.BackColor = System.Drawing.Color.Transparent;
            this.currentNeuronControl1.Location = new System.Drawing.Point(448, 223);
            this.currentNeuronControl1.MaximumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl1.MinimumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl1.Name = "currentNeuronControl1";
            this.currentNeuronControl1.Size = new System.Drawing.Size(340, 215);
            this.currentNeuronControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currentNeuronControl1);
            this.Name = "MainForm";
            this.Text = "OooКонструктор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CurrentNeuronControl currentNeuronControl1;
    }
}

