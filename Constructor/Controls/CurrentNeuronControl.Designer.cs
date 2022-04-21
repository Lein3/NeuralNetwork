namespace Constructor
{
    partial class CurrentNeuronControl
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
            this.label_Output = new System.Windows.Forms.Label();
            this.label_Sum = new System.Windows.Forms.Label();
            this.label_Min = new System.Windows.Forms.Label();
            this.label_Max = new System.Windows.Forms.Label();
            this.pictureBox_CurrentNeuron = new System.Windows.Forms.PictureBox();
            this.label_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CurrentNeuron)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Output
            // 
            this.label_Output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Output.BackColor = System.Drawing.Color.Transparent;
            this.label_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Output.Location = new System.Drawing.Point(248, 82);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(73, 17);
            this.label_Output.TabIndex = 9;
            this.label_Output.Text = "Y = output";
            this.label_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Sum
            // 
            this.label_Sum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Sum.BackColor = System.Drawing.Color.Transparent;
            this.label_Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sum.Location = new System.Drawing.Point(142, 96);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Size = new System.Drawing.Size(61, 17);
            this.label_Sum.TabIndex = 8;
            this.label_Sum.Text = "S = Sum";
            this.label_Sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Min
            // 
            this.label_Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Min.BackColor = System.Drawing.Color.Transparent;
            this.label_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Min.Location = new System.Drawing.Point(50, 140);
            this.label_Min.Name = "label_Min";
            this.label_Min.Size = new System.Drawing.Size(40, 20);
            this.label_Min.TabIndex = 7;
            this.label_Min.Text = "Min";
            this.label_Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Max
            // 
            this.label_Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Max.BackColor = System.Drawing.Color.Transparent;
            this.label_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Max.Location = new System.Drawing.Point(50, 70);
            this.label_Max.Name = "label_Max";
            this.label_Max.Size = new System.Drawing.Size(40, 20);
            this.label_Max.TabIndex = 6;
            this.label_Max.Text = "Max";
            this.label_Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_CurrentNeuron
            // 
            this.pictureBox_CurrentNeuron.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_CurrentNeuron.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_CurrentNeuron.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_CurrentNeuron.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_CurrentNeuron.Name = "pictureBox_CurrentNeuron";
            this.pictureBox_CurrentNeuron.Size = new System.Drawing.Size(340, 215);
            this.pictureBox_CurrentNeuron.TabIndex = 5;
            this.pictureBox_CurrentNeuron.TabStop = false;
            this.pictureBox_CurrentNeuron.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_CurrentNeuron_Paint);
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Name.Location = new System.Drawing.Point(133, 3);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(70, 35);
            this.label_Name.TabIndex = 10;
            this.label_Name.Text = "Name";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CurrentNeuronControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.label_Output);
            this.Controls.Add(this.label_Sum);
            this.Controls.Add(this.label_Min);
            this.Controls.Add(this.label_Max);
            this.Controls.Add(this.pictureBox_CurrentNeuron);
            this.MaximumSize = new System.Drawing.Size(340, 215);
            this.MinimumSize = new System.Drawing.Size(340, 215);
            this.Name = "CurrentNeuronControl";
            this.Size = new System.Drawing.Size(340, 215);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CurrentNeuron)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Label label_Sum;
        private System.Windows.Forms.Label label_Min;
        private System.Windows.Forms.Label label_Max;
        private System.Windows.Forms.PictureBox pictureBox_CurrentNeuron;
        private System.Windows.Forms.Label label_Name;
    }
}
