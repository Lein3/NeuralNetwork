namespace Constructor
{
    partial class UserModelControl
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
            this.label_InputNeurons = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_MiddleNeurons = new System.Windows.Forms.Label();
            this.label_OutputNeurons = new System.Windows.Forms.Label();
            this.label_Bias = new System.Windows.Forms.Label();
            this.label_ActivationFunction = new System.Windows.Forms.Label();
            this.label_CostFunction = new System.Windows.Forms.Label();
            this.label_MainSeparator = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_InputNeurons
            // 
            this.label_InputNeurons.AutoSize = true;
            this.label_InputNeurons.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InputNeurons.ForeColor = System.Drawing.Color.White;
            this.label_InputNeurons.Location = new System.Drawing.Point(10, 60);
            this.label_InputNeurons.Name = "label_InputNeurons";
            this.label_InputNeurons.Size = new System.Drawing.Size(142, 19);
            this.label_InputNeurons.TabIndex = 6;
            this.label_InputNeurons.Text = "Входные нейроны: ";
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.White;
            this.label_Name.Location = new System.Drawing.Point(10, 5);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(320, 40);
            this.label_Name.TabIndex = 5;
            this.label_Name.Text = "Название:\r\n";
            // 
            // label_MiddleNeurons
            // 
            this.label_MiddleNeurons.AutoSize = true;
            this.label_MiddleNeurons.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MiddleNeurons.ForeColor = System.Drawing.Color.White;
            this.label_MiddleNeurons.Location = new System.Drawing.Point(10, 100);
            this.label_MiddleNeurons.Name = "label_MiddleNeurons";
            this.label_MiddleNeurons.Size = new System.Drawing.Size(144, 19);
            this.label_MiddleNeurons.TabIndex = 8;
            this.label_MiddleNeurons.Text = "Скрытые нейроны: ";
            // 
            // label_OutputNeurons
            // 
            this.label_OutputNeurons.AutoSize = true;
            this.label_OutputNeurons.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OutputNeurons.ForeColor = System.Drawing.Color.White;
            this.label_OutputNeurons.Location = new System.Drawing.Point(10, 140);
            this.label_OutputNeurons.Name = "label_OutputNeurons";
            this.label_OutputNeurons.Size = new System.Drawing.Size(153, 19);
            this.label_OutputNeurons.TabIndex = 9;
            this.label_OutputNeurons.Text = "Выходные нейроны: ";
            // 
            // label_Bias
            // 
            this.label_Bias.AutoSize = true;
            this.label_Bias.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bias.ForeColor = System.Drawing.Color.White;
            this.label_Bias.Location = new System.Drawing.Point(10, 180);
            this.label_Bias.Name = "label_Bias";
            this.label_Bias.Size = new System.Drawing.Size(89, 19);
            this.label_Bias.TabIndex = 10;
            this.label_Bias.Text = "Смещение: ";
            // 
            // label_ActivationFunction
            // 
            this.label_ActivationFunction.AutoSize = true;
            this.label_ActivationFunction.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ActivationFunction.ForeColor = System.Drawing.Color.White;
            this.label_ActivationFunction.Location = new System.Drawing.Point(10, 220);
            this.label_ActivationFunction.Name = "label_ActivationFunction";
            this.label_ActivationFunction.Size = new System.Drawing.Size(151, 19);
            this.label_ActivationFunction.TabIndex = 11;
            this.label_ActivationFunction.Text = "Функция активации: ";
            // 
            // label_CostFunction
            // 
            this.label_CostFunction.AutoSize = true;
            this.label_CostFunction.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CostFunction.ForeColor = System.Drawing.Color.White;
            this.label_CostFunction.Location = new System.Drawing.Point(10, 260);
            this.label_CostFunction.Name = "label_CostFunction";
            this.label_CostFunction.Size = new System.Drawing.Size(133, 19);
            this.label_CostFunction.TabIndex = 12;
            this.label_CostFunction.Text = "Функция ошибки: ";
            // 
            // label_MainSeparator
            // 
            this.label_MainSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_MainSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.label_MainSeparator.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label_MainSeparator.ForeColor = System.Drawing.Color.White;
            this.label_MainSeparator.Location = new System.Drawing.Point(10, 50);
            this.label_MainSeparator.Name = "label_MainSeparator";
            this.label_MainSeparator.Size = new System.Drawing.Size(300, 2);
            this.label_MainSeparator.TabIndex = 13;
            this.label_MainSeparator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UserModelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.label_MainSeparator);
            this.Controls.Add(this.label_CostFunction);
            this.Controls.Add(this.label_ActivationFunction);
            this.Controls.Add(this.label_Bias);
            this.Controls.Add(this.label_OutputNeurons);
            this.Controls.Add(this.label_MiddleNeurons);
            this.Controls.Add(this.label_InputNeurons);
            this.Controls.Add(this.label_Name);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.MinimumSize = new System.Drawing.Size(2, 100);
            this.Name = "UserModelControl";
            this.Size = new System.Drawing.Size(345, 300);
            this.MouseLeave += new System.EventHandler(this.UserModelControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_InputNeurons;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_MiddleNeurons;
        private System.Windows.Forms.Label label_OutputNeurons;
        private System.Windows.Forms.Label label_Bias;
        private System.Windows.Forms.Label label_ActivationFunction;
        private System.Windows.Forms.Label label_CostFunction;
        private System.Windows.Forms.Label label_MainSeparator;
    }
}
