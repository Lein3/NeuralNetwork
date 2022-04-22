namespace Constructor
{
    partial class CreateInputLayerForm
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
            this.panel_neurons = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButton_yes1 = new System.Windows.Forms.RadioButton();
            this.radioButton_no1 = new System.Windows.Forms.RadioButton();
            this.label_normalization1 = new System.Windows.Forms.Label();
            this.label_fileName = new System.Windows.Forms.Label();
            this.button_readFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.radioButton_yes2 = new System.Windows.Forms.RadioButton();
            this.radioButton_no2 = new System.Windows.Forms.RadioButton();
            this.label_normalization2 = new System.Windows.Forms.Label();
            this.numericUpDown_Neurons = new System.Windows.Forms.NumericUpDown();
            this.label_neurons = new System.Windows.Forms.Label();
            this.label_warning = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.currentNeuronControl = new Constructor.CurrentNeuronControl();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Neurons)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_neurons
            // 
            this.panel_neurons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_neurons.AutoScroll = true;
            this.panel_neurons.BackColor = System.Drawing.Color.White;
            this.panel_neurons.Location = new System.Drawing.Point(12, 246);
            this.panel_neurons.Name = "panel_neurons";
            this.panel_neurons.Size = new System.Drawing.Size(1105, 458);
            this.panel_neurons.TabIndex = 2;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(730, 215);
            this.tabControl.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButton_yes1);
            this.tabPage1.Controls.Add(this.radioButton_no1);
            this.tabPage1.Controls.Add(this.label_normalization1);
            this.tabPage1.Controls.Add(this.label_fileName);
            this.tabPage1.Controls.Add(this.button_readFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автоматически";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton_yes1
            // 
            this.radioButton_yes1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_yes1.Location = new System.Drawing.Point(560, 145);
            this.radioButton_yes1.Name = "radioButton_yes1";
            this.radioButton_yes1.Size = new System.Drawing.Size(40, 20);
            this.radioButton_yes1.TabIndex = 8;
            this.radioButton_yes1.Text = "да";
            this.radioButton_yes1.UseVisualStyleBackColor = true;
            // 
            // radioButton_no1
            // 
            this.radioButton_no1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_no1.Checked = true;
            this.radioButton_no1.Location = new System.Drawing.Point(490, 145);
            this.radioButton_no1.Name = "radioButton_no1";
            this.radioButton_no1.Size = new System.Drawing.Size(45, 20);
            this.radioButton_no1.TabIndex = 7;
            this.radioButton_no1.TabStop = true;
            this.radioButton_no1.Text = "нет";
            this.radioButton_no1.UseVisualStyleBackColor = true;
            // 
            // label_normalization1
            // 
            this.label_normalization1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_normalization1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_normalization1.Location = new System.Drawing.Point(130, 140);
            this.label_normalization1.Name = "label_normalization1";
            this.label_normalization1.Size = new System.Drawing.Size(335, 25);
            this.label_normalization1.TabIndex = 6;
            this.label_normalization1.Text = "Разрешить ручную нормализацию";
            // 
            // label_fileName
            // 
            this.label_fileName.AutoSize = true;
            this.label_fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fileName.Location = new System.Drawing.Point(363, 99);
            this.label_fileName.Name = "label_fileName";
            this.label_fileName.Size = new System.Drawing.Size(0, 25);
            this.label_fileName.TabIndex = 1;
            this.label_fileName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button_readFile
            // 
            this.button_readFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_readFile.Location = new System.Drawing.Point(300, 40);
            this.button_readFile.Name = "button_readFile";
            this.button_readFile.Size = new System.Drawing.Size(140, 45);
            this.button_readFile.TabIndex = 0;
            this.button_readFile.Text = "Прочитать файл";
            this.button_readFile.UseVisualStyleBackColor = true;
            this.button_readFile.Click += new System.EventHandler(this.button_readFile_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioButton_yes2);
            this.tabPage2.Controls.Add(this.radioButton_no2);
            this.tabPage2.Controls.Add(this.label_normalization2);
            this.tabPage2.Controls.Add(this.numericUpDown_Neurons);
            this.tabPage2.Controls.Add(this.label_neurons);
            this.tabPage2.Controls.Add(this.label_warning);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вручную";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton_yes2
            // 
            this.radioButton_yes2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_yes2.Location = new System.Drawing.Point(560, 145);
            this.radioButton_yes2.Name = "radioButton_yes2";
            this.radioButton_yes2.Size = new System.Drawing.Size(40, 20);
            this.radioButton_yes2.TabIndex = 5;
            this.radioButton_yes2.Text = "да";
            this.radioButton_yes2.UseVisualStyleBackColor = true;
            // 
            // radioButton_no2
            // 
            this.radioButton_no2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButton_no2.Checked = true;
            this.radioButton_no2.Location = new System.Drawing.Point(490, 145);
            this.radioButton_no2.Name = "radioButton_no2";
            this.radioButton_no2.Size = new System.Drawing.Size(45, 20);
            this.radioButton_no2.TabIndex = 4;
            this.radioButton_no2.TabStop = true;
            this.radioButton_no2.Text = "нет";
            this.radioButton_no2.UseVisualStyleBackColor = true;
            // 
            // label_normalization2
            // 
            this.label_normalization2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_normalization2.AutoSize = true;
            this.label_normalization2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_normalization2.Location = new System.Drawing.Point(130, 140);
            this.label_normalization2.Name = "label_normalization2";
            this.label_normalization2.Size = new System.Drawing.Size(334, 25);
            this.label_normalization2.TabIndex = 3;
            this.label_normalization2.Text = "Разрешить ручную нормализацию";
            // 
            // numericUpDown_Neurons
            // 
            this.numericUpDown_Neurons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_Neurons.Location = new System.Drawing.Point(307, 87);
            this.numericUpDown_Neurons.Name = "numericUpDown_Neurons";
            this.numericUpDown_Neurons.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Neurons.TabIndex = 2;
            this.numericUpDown_Neurons.ValueChanged += new System.EventHandler(this.numericUpDown_Neurons_ValueChanged);
            // 
            // label_neurons
            // 
            this.label_neurons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_neurons.AutoSize = true;
            this.label_neurons.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_neurons.Location = new System.Drawing.Point(257, 48);
            this.label_neurons.Name = "label_neurons";
            this.label_neurons.Size = new System.Drawing.Size(215, 25);
            this.label_neurons.TabIndex = 1;
            this.label_neurons.Text = "Количество нейронов";
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.Location = new System.Drawing.Point(7, 7);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(313, 13);
            this.label_warning.TabIndex = 0;
            this.label_warning.Text = "не рекомендуется делать настройку входного слоя вручную";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "CSV files (*.csv)|*.csv| txt files (*.txt) | *.txt | All files (*.*)|*.*";
            // 
            // currentNeuronControl
            // 
            this.currentNeuronControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentNeuronControl.BackColor = System.Drawing.Color.Transparent;
            this.currentNeuronControl.CurrentNeuron = null;
            this.currentNeuronControl.Enabled = false;
            this.currentNeuronControl.Location = new System.Drawing.Point(777, 12);
            this.currentNeuronControl.MaximumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.MinimumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.Name = "currentNeuronControl";
            this.currentNeuronControl.Size = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.TabIndex = 0;
            // 
            // CreateInputLayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 716);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel_neurons);
            this.Controls.Add(this.currentNeuronControl);
            this.Name = "CreateInputLayerForm";
            this.Text = "OooКонструктор";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Neurons)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CurrentNeuronControl currentNeuronControl;
        private System.Windows.Forms.Button button_readFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label_fileName;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.Label label_neurons;
        public System.Windows.Forms.TabControl tabControl;
        public System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.NumericUpDown numericUpDown_Neurons;
        private System.Windows.Forms.Label label_normalization1;
        private System.Windows.Forms.Label label_normalization2;
        public System.Windows.Forms.RadioButton radioButton_yes1;
        public System.Windows.Forms.RadioButton radioButton_no1;
        public System.Windows.Forms.RadioButton radioButton_yes2;
        public System.Windows.Forms.RadioButton radioButton_no2;
        protected System.Windows.Forms.Panel panel_neurons;
    }
}

