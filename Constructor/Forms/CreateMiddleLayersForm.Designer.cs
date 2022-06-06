namespace Constructor
{
    partial class CreateMiddleLayersForm
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
            this.tabControl_this = new System.Windows.Forms.TabControl();
            this.tabPage_thisNormal = new System.Windows.Forms.TabPage();
            this.tabPage_thisOut = new System.Windows.Forms.TabPage();
            this.label_neuronOut = new System.Windows.Forms.Label();
            this.numericUpDown_out = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_main = new System.Windows.Forms.NumericUpDown();
            this.label_neuronsMain = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Neurons)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl_this.SuspendLayout();
            this.tabPage_thisOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_main)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(761, 12);
            this.tabControl.Size = new System.Drawing.Size(10, 216);
            this.tabControl.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Size = new System.Drawing.Size(2, 190);
            // 
            // panel_neurons
            // 
            this.panel_neurons.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawSeparator);
            // 
            // tabPage1
            // 
            this.tabPage1.Size = new System.Drawing.Size(2, 190);
            // 
            // radioButton_yes1
            // 
            this.radioButton_yes1.Location = new System.Drawing.Point(200, 145);
            // 
            // radioButton_no1
            // 
            this.radioButton_no1.Location = new System.Drawing.Point(130, 145);
            // 
            // tabControl_this
            // 
            this.tabControl_this.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_this.Controls.Add(this.tabPage_thisNormal);
            this.tabControl_this.Controls.Add(this.tabPage_thisOut);
            this.tabControl_this.Location = new System.Drawing.Point(12, 34);
            this.tabControl_this.Name = "tabControl_this";
            this.tabControl_this.SelectedIndex = 0;
            this.tabControl_this.Size = new System.Drawing.Size(728, 190);
            this.tabControl_this.TabIndex = 4;
            // 
            // tabPage_thisNormal
            // 
            this.tabPage_thisNormal.Location = new System.Drawing.Point(4, 22);
            this.tabPage_thisNormal.Name = "tabPage_thisNormal";
            this.tabPage_thisNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_thisNormal.Size = new System.Drawing.Size(720, 164);
            this.tabPage_thisNormal.TabIndex = 0;
            this.tabPage_thisNormal.Text = "Создание Скрытых слоев";
            this.tabPage_thisNormal.UseVisualStyleBackColor = true;
            this.tabPage_thisNormal.Enter += new System.EventHandler(this.tabPage_thisNormal_Enter);
            // 
            // tabPage_thisOut
            // 
            this.tabPage_thisOut.Controls.Add(this.label_neuronOut);
            this.tabPage_thisOut.Controls.Add(this.numericUpDown_out);
            this.tabPage_thisOut.Location = new System.Drawing.Point(4, 22);
            this.tabPage_thisOut.Name = "tabPage_thisOut";
            this.tabPage_thisOut.Size = new System.Drawing.Size(720, 164);
            this.tabPage_thisOut.TabIndex = 1;
            this.tabPage_thisOut.Text = "Выходные нейроны";
            this.tabPage_thisOut.UseVisualStyleBackColor = true;
            this.tabPage_thisOut.Enter += new System.EventHandler(this.tabPage_thisOut_Enter);
            // 
            // label_neuronOut
            // 
            this.label_neuronOut.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_neuronOut.AutoSize = true;
            this.label_neuronOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_neuronOut.Location = new System.Drawing.Point(200, 55);
            this.label_neuronOut.Name = "label_neuronOut";
            this.label_neuronOut.Size = new System.Drawing.Size(215, 25);
            this.label_neuronOut.TabIndex = 4;
            this.label_neuronOut.Text = "Количество нейронов";
            this.label_neuronOut.Visible = false;
            // 
            // numericUpDown_out
            // 
            this.numericUpDown_out.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_out.Location = new System.Drawing.Point(435, 60);
            this.numericUpDown_out.Name = "numericUpDown_out";
            this.numericUpDown_out.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_out.TabIndex = 5;
            this.numericUpDown_out.Visible = false;
            this.numericUpDown_out.ValueChanged += new System.EventHandler(this.numericUpDown_out_ValueChanged);
            // 
            // numericUpDown_main
            // 
            this.numericUpDown_main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_main.Location = new System.Drawing.Point(450, 15);
            this.numericUpDown_main.Name = "numericUpDown_main";
            this.numericUpDown_main.Size = new System.Drawing.Size(75, 20);
            this.numericUpDown_main.TabIndex = 3;
            this.numericUpDown_main.ValueChanged += new System.EventHandler(this.numericUpDown_main_ValueChanged);
            // 
            // label_neuronsMain
            // 
            this.label_neuronsMain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_neuronsMain.AutoSize = true;
            this.label_neuronsMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_neuronsMain.Location = new System.Drawing.Point(240, 10);
            this.label_neuronsMain.Name = "label_neuronsMain";
            this.label_neuronsMain.Size = new System.Drawing.Size(182, 25);
            this.label_neuronsMain.TabIndex = 2;
            this.label_neuronsMain.Text = "Количество слоев";
            // 
            // CreateMiddleLayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1129, 716);
            this.Controls.Add(this.label_neuronsMain);
            this.Controls.Add(this.numericUpDown_main);
            this.Controls.Add(this.tabControl_this);
            this.Name = "CreateMiddleLayersForm";
            this.Controls.SetChildIndex(this.panel_neurons, 0);
            this.Controls.SetChildIndex(this.tabControl, 0);
            this.Controls.SetChildIndex(this.tabControl_this, 0);
            this.Controls.SetChildIndex(this.numericUpDown_main, 0);
            this.Controls.SetChildIndex(this.label_neuronsMain, 0);
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Neurons)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl_this.ResumeLayout(false);
            this.tabPage_thisOut.ResumeLayout(false);
            this.tabPage_thisOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_this;
        private System.Windows.Forms.TabPage tabPage_thisNormal;
        private System.Windows.Forms.NumericUpDown numericUpDown_main;
        private System.Windows.Forms.Label label_neuronsMain;
        private System.Windows.Forms.TabPage tabPage_thisOut;
        private System.Windows.Forms.Label label_neuronOut;
        private System.Windows.Forms.NumericUpDown numericUpDown_out;
    }
}