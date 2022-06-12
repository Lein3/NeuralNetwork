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
            this.label_ActivationFunction = new System.Windows.Forms.Label();
            this.numericUpDown_Max = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Min = new System.Windows.Forms.NumericUpDown();
            this.textBox_ChangeNeuronName = new System.Windows.Forms.TextBox();
            this.comboBox_SelectActivationFunction = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CurrentNeuron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Output
            // 
            this.label_Output.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Output.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.label_Output.ForeColor = System.Drawing.Color.White;
            this.label_Output.Location = new System.Drawing.Point(135, 110);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(73, 17);
            this.label_Output.TabIndex = 9;
            this.label_Output.Text = "Y = output";
            this.label_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Sum
            // 
            this.label_Sum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Sum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Sum.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.label_Sum.ForeColor = System.Drawing.Color.White;
            this.label_Sum.Location = new System.Drawing.Point(140, 95);
            this.label_Sum.Name = "label_Sum";
            this.label_Sum.Size = new System.Drawing.Size(61, 17);
            this.label_Sum.TabIndex = 8;
            this.label_Sum.Text = "S = Sum";
            this.label_Sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Min
            // 
            this.label_Min.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Min.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.label_Min.ForeColor = System.Drawing.Color.White;
            this.label_Min.Location = new System.Drawing.Point(50, 140);
            this.label_Min.Name = "label_Min";
            this.label_Min.Size = new System.Drawing.Size(40, 20);
            this.label_Min.TabIndex = 7;
            this.label_Min.Text = "Min";
            this.label_Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Min.DoubleClick += new System.EventHandler(this.label_Min_DoubleClick);
            // 
            // label_Max
            // 
            this.label_Max.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Max.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.label_Max.ForeColor = System.Drawing.Color.White;
            this.label_Max.Location = new System.Drawing.Point(50, 70);
            this.label_Max.Name = "label_Max";
            this.label_Max.Size = new System.Drawing.Size(40, 20);
            this.label_Max.TabIndex = 6;
            this.label_Max.Text = "Max";
            this.label_Max.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Max.DoubleClick += new System.EventHandler(this.label_Max_DoubleClick);
            // 
            // pictureBox_CurrentNeuron
            // 
            this.pictureBox_CurrentNeuron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
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
            this.label_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_Name.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(107, 5);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(127, 30);
            this.label_Name.TabIndex = 10;
            this.label_Name.Text = "Имя";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Name.DoubleClick += new System.EventHandler(this.label_Name_DoubleClick);
            // 
            // label_ActivationFunction
            // 
            this.label_ActivationFunction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_ActivationFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label_ActivationFunction.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.label_ActivationFunction.ForeColor = System.Drawing.Color.White;
            this.label_ActivationFunction.Location = new System.Drawing.Point(75, 185);
            this.label_ActivationFunction.Name = "label_ActivationFunction";
            this.label_ActivationFunction.Size = new System.Drawing.Size(185, 25);
            this.label_ActivationFunction.TabIndex = 11;
            this.label_ActivationFunction.Text = "Функция активации";
            this.label_ActivationFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_ActivationFunction.DoubleClick += new System.EventHandler(this.label_ActivationFunction_DoubleClick);
            // 
            // numericUpDown_Max
            // 
            this.numericUpDown_Max.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_Max.DecimalPlaces = 2;
            this.numericUpDown_Max.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Max.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_Max.Location = new System.Drawing.Point(40, 40);
            this.numericUpDown_Max.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_Max.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Max.Name = "numericUpDown_Max";
            this.numericUpDown_Max.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown_Max.TabIndex = 42;
            this.numericUpDown_Max.Visible = false;
            this.numericUpDown_Max.ValueChanged += new System.EventHandler(this.numericUpDown_Max_ValueChanged);
            // 
            // numericUpDown_Min
            // 
            this.numericUpDown_Min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_Min.DecimalPlaces = 2;
            this.numericUpDown_Min.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Min.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_Min.Location = new System.Drawing.Point(40, 160);
            this.numericUpDown_Min.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_Min.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Min.Name = "numericUpDown_Min";
            this.numericUpDown_Min.Size = new System.Drawing.Size(55, 22);
            this.numericUpDown_Min.TabIndex = 43;
            this.numericUpDown_Min.Visible = false;
            this.numericUpDown_Min.ValueChanged += new System.EventHandler(this.numericUpDown_Min_ValueChanged);
            // 
            // textBox_ChangeNeuronName
            // 
            this.textBox_ChangeNeuronName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_ChangeNeuronName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_ChangeNeuronName.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.textBox_ChangeNeuronName.ForeColor = System.Drawing.Color.White;
            this.textBox_ChangeNeuronName.Location = new System.Drawing.Point(200, 10);
            this.textBox_ChangeNeuronName.Name = "textBox_ChangeNeuronName";
            this.textBox_ChangeNeuronName.Size = new System.Drawing.Size(120, 22);
            this.textBox_ChangeNeuronName.TabIndex = 44;
            this.textBox_ChangeNeuronName.Visible = false;
            this.textBox_ChangeNeuronName.TextChanged += new System.EventHandler(this.textBox_ChangeNeuronName_TextChanged);
            this.textBox_ChangeNeuronName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_ChangeNeuronName_KeyDown);
            // 
            // comboBox_SelectActivationFunction
            // 
            this.comboBox_SelectActivationFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_SelectActivationFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectActivationFunction.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_SelectActivationFunction.ForeColor = System.Drawing.Color.White;
            this.comboBox_SelectActivationFunction.FormattingEnabled = true;
            this.comboBox_SelectActivationFunction.Location = new System.Drawing.Point(186, 185);
            this.comboBox_SelectActivationFunction.Name = "comboBox_SelectActivationFunction";
            this.comboBox_SelectActivationFunction.Size = new System.Drawing.Size(123, 23);
            this.comboBox_SelectActivationFunction.TabIndex = 45;
            this.comboBox_SelectActivationFunction.Visible = false;
            // 
            // CurrentNeuronControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.comboBox_SelectActivationFunction);
            this.Controls.Add(this.textBox_ChangeNeuronName);
            this.Controls.Add(this.numericUpDown_Min);
            this.Controls.Add(this.numericUpDown_Max);
            this.Controls.Add(this.label_ActivationFunction);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Min)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.Label label_Sum;
        private System.Windows.Forms.Label label_Min;
        private System.Windows.Forms.Label label_Max;
        private System.Windows.Forms.PictureBox pictureBox_CurrentNeuron;
        public System.Windows.Forms.Label label_Name;
        public System.Windows.Forms.Label label_ActivationFunction;
        private System.Windows.Forms.NumericUpDown numericUpDown_Max;
        private System.Windows.Forms.NumericUpDown numericUpDown_Min;
        private System.Windows.Forms.TextBox textBox_ChangeNeuronName;
        private System.Windows.Forms.ComboBox comboBox_SelectActivationFunction;
    }
}
