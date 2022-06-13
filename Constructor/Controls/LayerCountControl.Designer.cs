namespace Constructor
{
    partial class LayerCountControl
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
            this.label_LayerName = new System.Windows.Forms.Label();
            this.numericUpDown_LayerNeuronsCount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LayerNeuronsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label_LayerName
            // 
            this.label_LayerName.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LayerName.ForeColor = System.Drawing.Color.White;
            this.label_LayerName.Location = new System.Drawing.Point(0, 0);
            this.label_LayerName.Name = "label_LayerName";
            this.label_LayerName.Size = new System.Drawing.Size(55, 15);
            this.label_LayerName.TabIndex = 4;
            this.label_LayerName.Text = "Слой ";
            this.label_LayerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_LayerNeuronsCount
            // 
            this.numericUpDown_LayerNeuronsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_LayerNeuronsCount.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_LayerNeuronsCount.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_LayerNeuronsCount.Location = new System.Drawing.Point(5, 20);
            this.numericUpDown_LayerNeuronsCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_LayerNeuronsCount.Name = "numericUpDown_LayerNeuronsCount";
            this.numericUpDown_LayerNeuronsCount.Size = new System.Drawing.Size(40, 22);
            this.numericUpDown_LayerNeuronsCount.TabIndex = 44;
            this.numericUpDown_LayerNeuronsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LayerCountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.numericUpDown_LayerNeuronsCount);
            this.Controls.Add(this.label_LayerName);
            this.Name = "LayerCountControl";
            this.Size = new System.Drawing.Size(57, 52);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LayerNeuronsCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_LayerName;
        public System.Windows.Forms.NumericUpDown numericUpDown_LayerNeuronsCount;
    }
}
