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
            this.currentNeuronControl1 = new Constructor.CurrentNeuronControl();
            this.panel_Neurons = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentNeuronControl1
            // 
            this.currentNeuronControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentNeuronControl1.BackColor = System.Drawing.Color.Transparent;
            this.currentNeuronControl1.Location = new System.Drawing.Point(777, 12);
            this.currentNeuronControl1.MaximumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl1.MinimumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl1.Name = "currentNeuronControl1";
            this.currentNeuronControl1.Size = new System.Drawing.Size(340, 215);
            this.currentNeuronControl1.TabIndex = 0;
            // 
            // panel_Neurons
            // 
            this.panel_Neurons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Neurons.AutoScroll = true;
            this.panel_Neurons.BackColor = System.Drawing.Color.Silver;
            this.panel_Neurons.Location = new System.Drawing.Point(12, 246);
            this.panel_Neurons.Name = "panel_Neurons";
            this.panel_Neurons.Size = new System.Drawing.Size(1105, 457);
            this.panel_Neurons.TabIndex = 2;
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
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 189);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Автоматически";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 189);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вручную";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CreateInputLayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1129, 715);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel_Neurons);
            this.Controls.Add(this.currentNeuronControl1);
            this.Name = "CreateInputLayerForm";
            this.Text = "OooКонструктор";
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CurrentNeuronControl currentNeuronControl1;
        private System.Windows.Forms.Panel panel_Neurons;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

