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
            this.label_Description = new System.Windows.Forms.Label();
            this.panel_Neurons = new System.Windows.Forms.Panel();
            this.checkBox_FromFileSaveCheck = new System.Windows.Forms.CheckBox();
            this.label_NeuronsCount = new System.Windows.Forms.Label();
            this.numericUpDown_NeuronsCount = new System.Windows.Forms.NumericUpDown();
            this.currentNeuronControl = new Constructor.CurrentNeuronControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NeuronsCount)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.ForeColor = System.Drawing.Color.White;
            this.label_Description.Location = new System.Drawing.Point(15, 15);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(301, 30);
            this.label_Description.TabIndex = 2;
            this.label_Description.Text = "Создание входного слоя";
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
            this.panel_Neurons.Size = new System.Drawing.Size(775, 525);
            this.panel_Neurons.TabIndex = 7;
            // 
            // checkBox_FromFileSaveCheck
            // 
            this.checkBox_FromFileSaveCheck.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.checkBox_FromFileSaveCheck.ForeColor = System.Drawing.Color.White;
            this.checkBox_FromFileSaveCheck.Location = new System.Drawing.Point(20, 60);
            this.checkBox_FromFileSaveCheck.Name = "checkBox_FromFileSaveCheck";
            this.checkBox_FromFileSaveCheck.Size = new System.Drawing.Size(250, 20);
            this.checkBox_FromFileSaveCheck.TabIndex = 39;
            this.checkBox_FromFileSaveCheck.Text = "Использовать нейроны смещения";
            this.checkBox_FromFileSaveCheck.UseVisualStyleBackColor = true;
            // 
            // label_NeuronsCount
            // 
            this.label_NeuronsCount.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NeuronsCount.ForeColor = System.Drawing.Color.White;
            this.label_NeuronsCount.Location = new System.Drawing.Point(70, 100);
            this.label_NeuronsCount.Name = "label_NeuronsCount";
            this.label_NeuronsCount.Size = new System.Drawing.Size(160, 20);
            this.label_NeuronsCount.TabIndex = 40;
            this.label_NeuronsCount.Text = "Количество нейронов\r\n";
            // 
            // numericUpDown_NeuronsCount
            // 
            this.numericUpDown_NeuronsCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.numericUpDown_NeuronsCount.Enabled = false;
            this.numericUpDown_NeuronsCount.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_NeuronsCount.ForeColor = System.Drawing.Color.White;
            this.numericUpDown_NeuronsCount.Location = new System.Drawing.Point(20, 95);
            this.numericUpDown_NeuronsCount.Name = "numericUpDown_NeuronsCount";
            this.numericUpDown_NeuronsCount.Size = new System.Drawing.Size(40, 25);
            this.numericUpDown_NeuronsCount.TabIndex = 41;
            // 
            // currentNeuronControl
            // 
            this.currentNeuronControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentNeuronControl.BackColor = System.Drawing.Color.White;
            this.currentNeuronControl.CurrentNeuron = null;
            this.currentNeuronControl.Location = new System.Drawing.Point(450, 32);
            this.currentNeuronControl.MaximumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.MinimumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.Name = "currentNeuronControl";
            this.currentNeuronControl.Size = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage1.Controls.Add(this.label_Description);
            this.tabPage1.Controls.Add(this.numericUpDown_NeuronsCount);
            this.tabPage1.Controls.Add(this.checkBox_FromFileSaveCheck);
            this.tabPage1.Controls.Add(this.label_NeuronsCount);
            this.tabPage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(412, 209);
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
            this.tabControl.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(15, 10);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(420, 237);
            this.tabControl.TabIndex = 42;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(412, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Скрытые слои";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(412, 209);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Выходной слой";
            // 
            // NetworkConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 800);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NeuronsCount)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Panel panel_Neurons;
        private System.Windows.Forms.CheckBox checkBox_FromFileSaveCheck;
        private System.Windows.Forms.Label label_NeuronsCount;
        private System.Windows.Forms.NumericUpDown numericUpDown_NeuronsCount;
        public CurrentNeuronControl currentNeuronControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
    }
}