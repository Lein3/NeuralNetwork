namespace Constructor
{
    partial class NetworkConfigurationForm
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
            this.label_DescriptionInput = new System.Windows.Forms.Label();
            this.panel_Neurons = new System.Windows.Forms.Panel();
            this.label_NeuronsCountInput = new System.Windows.Forms.Label();
            this.numericUpDown_NeuronsCountInput = new System.Windows.Forms.NumericUpDown();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label_SelectActivationFunctionMiddle = new System.Windows.Forms.Label();
            this.comboBox_SelectActivationFunctionMiddle = new System.Windows.Forms.ComboBox();
            this.panel_LayerCountMiddle = new System.Windows.Forms.Panel();
            this.numericUpDown_LayersCountMiddle = new System.Windows.Forms.NumericUpDown();
            this.label_NeuronsCountMiddle = new System.Windows.Forms.Label();
            this.label_DescriptionMiddle = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_SelectActivationFunctionOutput = new System.Windows.Forms.Label();
            this.comboBox_SelectActivationFunctionOutput = new System.Windows.Forms.ComboBox();
            this.numericUpDown_NeuronsCountOutput = new System.Windows.Forms.NumericUpDown();
            this.label_DescriptionOutput = new System.Windows.Forms.Label();
            this.label_NeuronsCountOutput = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBox_DrawOnCenter = new System.Windows.Forms.CheckBox();
            this.checkBox_Bias = new System.Windows.Forms.CheckBox();
            this.currentNeuronControl = new Constructor.CurrentNeuronControl();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NeuronsCountInput)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LayersCountMiddle)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NeuronsCountOutput)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_DescriptionInput
            // 
            this.label_DescriptionInput.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescriptionInput.ForeColor = System.Drawing.Color.White;
            this.label_DescriptionInput.Location = new System.Drawing.Point(15, 10);
            this.label_DescriptionInput.Name = "label_DescriptionInput";
            this.label_DescriptionInput.Size = new System.Drawing.Size(305, 30);
            this.label_DescriptionInput.TabIndex = 2;
            this.label_DescriptionInput.Text = "Создание входного слоя";
            // 
            // panel_Neurons
            // 
            this.panel_Neurons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Neurons.AutoScroll = true;
            this.panel_Neurons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel_Neurons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Neurons.Location = new System.Drawing.Point(15, 265);
            this.panel_Neurons.Name = "panel_Neurons";
            this.panel_Neurons.Size = new System.Drawing.Size(875, 525);
            this.panel_Neurons.TabIndex = 7;
            this.panel_Neurons.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawSeparator);
            // 
            // label_NeuronsCountInput
            // 
            this.label_NeuronsCountInput.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NeuronsCountInput.ForeColor = System.Drawing.Color.White;
            this.label_NeuronsCountInput.Location = new System.Drawing.Point(70, 55);
            this.label_NeuronsCountInput.Name = "label_NeuronsCountInput";
            this.label_NeuronsCountInput.Size = new System.Drawing.Size(160, 20);
            this.label_NeuronsCountInput.TabIndex = 40;
            this.label_NeuronsCountInput.Text = "Количество нейронов\r\n";
            // 
            // numericUpDown_NeuronsCountInput
            // 
            this.numericUpDown_NeuronsCountInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_NeuronsCountInput.Enabled = false;
            this.numericUpDown_NeuronsCountInput.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_NeuronsCountInput.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_NeuronsCountInput.Location = new System.Drawing.Point(20, 50);
            this.numericUpDown_NeuronsCountInput.Name = "numericUpDown_NeuronsCountInput";
            this.numericUpDown_NeuronsCountInput.Size = new System.Drawing.Size(40, 22);
            this.numericUpDown_NeuronsCountInput.TabIndex = 41;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage1.Controls.Add(this.label_DescriptionInput);
            this.tabPage1.Controls.Add(this.numericUpDown_NeuronsCountInput);
            this.tabPage1.Controls.Add(this.label_NeuronsCountInput);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(512, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Входной слой";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(15, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(520, 237);
            this.tabControl.TabIndex = 42;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage2.Controls.Add(this.label_SelectActivationFunctionMiddle);
            this.tabPage2.Controls.Add(this.comboBox_SelectActivationFunctionMiddle);
            this.tabPage2.Controls.Add(this.panel_LayerCountMiddle);
            this.tabPage2.Controls.Add(this.numericUpDown_LayersCountMiddle);
            this.tabPage2.Controls.Add(this.label_NeuronsCountMiddle);
            this.tabPage2.Controls.Add(this.label_DescriptionMiddle);
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(512, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Скрытые слои";
            // 
            // label_SelectActivationFunctionMiddle
            // 
            this.label_SelectActivationFunctionMiddle.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectActivationFunctionMiddle.ForeColor = System.Drawing.Color.White;
            this.label_SelectActivationFunctionMiddle.Location = new System.Drawing.Point(360, 55);
            this.label_SelectActivationFunctionMiddle.Name = "label_SelectActivationFunctionMiddle";
            this.label_SelectActivationFunctionMiddle.Size = new System.Drawing.Size(144, 20);
            this.label_SelectActivationFunctionMiddle.TabIndex = 49;
            this.label_SelectActivationFunctionMiddle.Text = "Функция активации";
            // 
            // comboBox_SelectActivationFunctionMiddle
            // 
            this.comboBox_SelectActivationFunctionMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_SelectActivationFunctionMiddle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectActivationFunctionMiddle.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_SelectActivationFunctionMiddle.ForeColor = System.Drawing.Color.White;
            this.comboBox_SelectActivationFunctionMiddle.FormattingEnabled = true;
            this.comboBox_SelectActivationFunctionMiddle.Location = new System.Drawing.Point(230, 50);
            this.comboBox_SelectActivationFunctionMiddle.Name = "comboBox_SelectActivationFunctionMiddle";
            this.comboBox_SelectActivationFunctionMiddle.Size = new System.Drawing.Size(123, 23);
            this.comboBox_SelectActivationFunctionMiddle.TabIndex = 47;
            this.comboBox_SelectActivationFunctionMiddle.SelectionChangeCommitted += new System.EventHandler(this.comboBox_SelectActivationFunctionMiddle_SelectionChangeCommitted);
            // 
            // panel_LayerCountMiddle
            // 
            this.panel_LayerCountMiddle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_LayerCountMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel_LayerCountMiddle.Location = new System.Drawing.Point(5, 75);
            this.panel_LayerCountMiddle.Name = "panel_LayerCountMiddle";
            this.panel_LayerCountMiddle.Size = new System.Drawing.Size(500, 130);
            this.panel_LayerCountMiddle.TabIndex = 48;
            // 
            // numericUpDown_LayersCountMiddle
            // 
            this.numericUpDown_LayersCountMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_LayersCountMiddle.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_LayersCountMiddle.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_LayersCountMiddle.Location = new System.Drawing.Point(20, 50);
            this.numericUpDown_LayersCountMiddle.Name = "numericUpDown_LayersCountMiddle";
            this.numericUpDown_LayersCountMiddle.Size = new System.Drawing.Size(40, 22);
            this.numericUpDown_LayersCountMiddle.TabIndex = 43;
            this.numericUpDown_LayersCountMiddle.ValueChanged += new System.EventHandler(this.numericUpDown_LayersCountMiddle_ValueChanged);
            // 
            // label_NeuronsCountMiddle
            // 
            this.label_NeuronsCountMiddle.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NeuronsCountMiddle.ForeColor = System.Drawing.Color.White;
            this.label_NeuronsCountMiddle.Location = new System.Drawing.Point(70, 55);
            this.label_NeuronsCountMiddle.Name = "label_NeuronsCountMiddle";
            this.label_NeuronsCountMiddle.Size = new System.Drawing.Size(160, 20);
            this.label_NeuronsCountMiddle.TabIndex = 42;
            this.label_NeuronsCountMiddle.Text = "Количество слоев";
            // 
            // label_DescriptionMiddle
            // 
            this.label_DescriptionMiddle.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescriptionMiddle.ForeColor = System.Drawing.Color.White;
            this.label_DescriptionMiddle.Location = new System.Drawing.Point(15, 10);
            this.label_DescriptionMiddle.Name = "label_DescriptionMiddle";
            this.label_DescriptionMiddle.Size = new System.Drawing.Size(305, 30);
            this.label_DescriptionMiddle.TabIndex = 3;
            this.label_DescriptionMiddle.Text = "Создание скрытых слоев";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage3.Controls.Add(this.label_SelectActivationFunctionOutput);
            this.tabPage3.Controls.Add(this.comboBox_SelectActivationFunctionOutput);
            this.tabPage3.Controls.Add(this.numericUpDown_NeuronsCountOutput);
            this.tabPage3.Controls.Add(this.label_DescriptionOutput);
            this.tabPage3.Controls.Add(this.label_NeuronsCountOutput);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(512, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Выходной слой";
            // 
            // label_SelectActivationFunctionOutput
            // 
            this.label_SelectActivationFunctionOutput.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SelectActivationFunctionOutput.ForeColor = System.Drawing.Color.White;
            this.label_SelectActivationFunctionOutput.Location = new System.Drawing.Point(360, 55);
            this.label_SelectActivationFunctionOutput.Name = "label_SelectActivationFunctionOutput";
            this.label_SelectActivationFunctionOutput.Size = new System.Drawing.Size(144, 20);
            this.label_SelectActivationFunctionOutput.TabIndex = 51;
            this.label_SelectActivationFunctionOutput.Text = "Функция активации";
            // 
            // comboBox_SelectActivationFunctionOutput
            // 
            this.comboBox_SelectActivationFunctionOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_SelectActivationFunctionOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_SelectActivationFunctionOutput.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F);
            this.comboBox_SelectActivationFunctionOutput.ForeColor = System.Drawing.Color.White;
            this.comboBox_SelectActivationFunctionOutput.FormattingEnabled = true;
            this.comboBox_SelectActivationFunctionOutput.Location = new System.Drawing.Point(230, 50);
            this.comboBox_SelectActivationFunctionOutput.Name = "comboBox_SelectActivationFunctionOutput";
            this.comboBox_SelectActivationFunctionOutput.Size = new System.Drawing.Size(123, 23);
            this.comboBox_SelectActivationFunctionOutput.TabIndex = 50;
            this.comboBox_SelectActivationFunctionOutput.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectActivationFunctionOutput_SelectedIndexChanged);
            // 
            // numericUpDown_NeuronsCountOutput
            // 
            this.numericUpDown_NeuronsCountOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_NeuronsCountOutput.Font = new System.Drawing.Font("Microsoft JhengHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_NeuronsCountOutput.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_NeuronsCountOutput.Location = new System.Drawing.Point(20, 50);
            this.numericUpDown_NeuronsCountOutput.Name = "numericUpDown_NeuronsCountOutput";
            this.numericUpDown_NeuronsCountOutput.Size = new System.Drawing.Size(40, 22);
            this.numericUpDown_NeuronsCountOutput.TabIndex = 46;
            this.numericUpDown_NeuronsCountOutput.ValueChanged += new System.EventHandler(this.numericUpDown_NeuronsCountOutput_ValueChanged);
            // 
            // label_DescriptionOutput
            // 
            this.label_DescriptionOutput.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescriptionOutput.ForeColor = System.Drawing.Color.White;
            this.label_DescriptionOutput.Location = new System.Drawing.Point(70, 55);
            this.label_DescriptionOutput.Name = "label_DescriptionOutput";
            this.label_DescriptionOutput.Size = new System.Drawing.Size(160, 20);
            this.label_DescriptionOutput.TabIndex = 45;
            this.label_DescriptionOutput.Text = "Количество нейронов";
            // 
            // label_NeuronsCountOutput
            // 
            this.label_NeuronsCountOutput.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NeuronsCountOutput.ForeColor = System.Drawing.Color.White;
            this.label_NeuronsCountOutput.Location = new System.Drawing.Point(15, 10);
            this.label_NeuronsCountOutput.Name = "label_NeuronsCountOutput";
            this.label_NeuronsCountOutput.Size = new System.Drawing.Size(320, 30);
            this.label_NeuronsCountOutput.TabIndex = 44;
            this.label_NeuronsCountOutput.Text = "Создание выходного слоя";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage4.Controls.Add(this.checkBox_DrawOnCenter);
            this.tabPage4.Controls.Add(this.checkBox_Bias);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(512, 209);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Другие настройки";
            // 
            // checkBox_DrawOnCenter
            // 
            this.checkBox_DrawOnCenter.Checked = true;
            this.checkBox_DrawOnCenter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_DrawOnCenter.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.checkBox_DrawOnCenter.ForeColor = System.Drawing.Color.White;
            this.checkBox_DrawOnCenter.Location = new System.Drawing.Point(15, 55);
            this.checkBox_DrawOnCenter.Name = "checkBox_DrawOnCenter";
            this.checkBox_DrawOnCenter.Size = new System.Drawing.Size(250, 20);
            this.checkBox_DrawOnCenter.TabIndex = 41;
            this.checkBox_DrawOnCenter.Text = "Центрировать элементы";
            this.checkBox_DrawOnCenter.UseVisualStyleBackColor = true;
            this.checkBox_DrawOnCenter.CheckedChanged += new System.EventHandler(this.checkBox_DrawOnCenter_CheckedChanged);
            // 
            // checkBox_Bias
            // 
            this.checkBox_Bias.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.checkBox_Bias.ForeColor = System.Drawing.Color.White;
            this.checkBox_Bias.Location = new System.Drawing.Point(15, 20);
            this.checkBox_Bias.Name = "checkBox_Bias";
            this.checkBox_Bias.Size = new System.Drawing.Size(250, 20);
            this.checkBox_Bias.TabIndex = 40;
            this.checkBox_Bias.Text = "Использовать нейроны смещения";
            this.checkBox_Bias.UseVisualStyleBackColor = true;
            this.checkBox_Bias.CheckedChanged += new System.EventHandler(this.checkBox_Bias_CheckedChanged);
            // 
            // currentNeuronControl
            // 
            this.currentNeuronControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentNeuronControl.BackColor = System.Drawing.Color.White;
            this.currentNeuronControl.CurrentNeuron = null;
            this.currentNeuronControl.Location = new System.Drawing.Point(550, 32);
            this.currentNeuronControl.MaximumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.MinimumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.Name = "currentNeuronControl";
            this.currentNeuronControl.Size = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.TabIndex = 6;
            // 
            // NetworkConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(900, 800);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel_Neurons);
            this.Controls.Add(this.currentNeuronControl);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NeuronsCountInput)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LayersCountMiddle)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NeuronsCountOutput)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_DescriptionInput;
        private System.Windows.Forms.Panel panel_Neurons;
        private System.Windows.Forms.Label label_NeuronsCountInput;
        private System.Windows.Forms.NumericUpDown numericUpDown_NeuronsCountInput;
        public CurrentNeuronControl currentNeuronControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown numericUpDown_LayersCountMiddle;
        private System.Windows.Forms.Label label_NeuronsCountMiddle;
        private System.Windows.Forms.Label label_DescriptionMiddle;
        private System.Windows.Forms.NumericUpDown numericUpDown_NeuronsCountOutput;
        private System.Windows.Forms.Label label_DescriptionOutput;
        private System.Windows.Forms.Label label_NeuronsCountOutput;
        private System.Windows.Forms.Panel panel_LayerCountMiddle;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBox_Bias;
        private System.Windows.Forms.CheckBox checkBox_DrawOnCenter;
        private System.Windows.Forms.ComboBox comboBox_SelectActivationFunctionMiddle;
        private System.Windows.Forms.Label label_SelectActivationFunctionMiddle;
        private System.Windows.Forms.Label label_SelectActivationFunctionOutput;
        private System.Windows.Forms.ComboBox comboBox_SelectActivationFunctionOutput;
    }
}