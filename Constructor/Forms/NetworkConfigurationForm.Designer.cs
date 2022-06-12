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
            this.label_Description2 = new System.Windows.Forms.Label();
            this.currentNeuronControl = new Constructor.CurrentNeuronControl();
            this.panel_Neurons = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.ForeColor = System.Drawing.Color.White;
            this.label_Description.Location = new System.Drawing.Point(10, 10);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(280, 30);
            this.label_Description.TabIndex = 2;
            this.label_Description.Text = "Создаем входной слой";
            // 
            // label_Description2
            // 
            this.label_Description2.AutoSize = true;
            this.label_Description2.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description2.ForeColor = System.Drawing.Color.White;
            this.label_Description2.Location = new System.Drawing.Point(10, 50);
            this.label_Description2.Name = "label_Description2";
            this.label_Description2.Size = new System.Drawing.Size(157, 17);
            this.label_Description2.TabIndex = 5;
            this.label_Description2.Text = "Создаем входной слой\r\n";
            // 
            // currentNeuronControl
            // 
            this.currentNeuronControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.currentNeuronControl.BackColor = System.Drawing.Color.White;
            this.currentNeuronControl.CurrentNeuron = null;
            this.currentNeuronControl.Location = new System.Drawing.Point(450, 10);
            this.currentNeuronControl.MaximumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.MinimumSize = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.Name = "currentNeuronControl";
            this.currentNeuronControl.Size = new System.Drawing.Size(340, 215);
            this.currentNeuronControl.TabIndex = 6;
            // 
            // panel_Neurons
            // 
            this.panel_Neurons.Location = new System.Drawing.Point(15, 240);
            this.panel_Neurons.Name = "panel_Neurons";
            this.panel_Neurons.Size = new System.Drawing.Size(775, 550);
            this.panel_Neurons.TabIndex = 7;
            // 
            // NetworkConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Neurons);
            this.Controls.Add(this.currentNeuronControl);
            this.Controls.Add(this.label_Description2);
            this.Controls.Add(this.label_Description);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NetworkConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.Label label_Description2;
        private CurrentNeuronControl currentNeuronControl;
        private System.Windows.Forms.Panel panel_Neurons;
    }
}