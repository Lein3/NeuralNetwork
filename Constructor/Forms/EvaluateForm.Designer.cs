namespace Constructor
{
    partial class EvaluateForm
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
            this.dataGridView_learning = new System.Windows.Forms.DataGridView();
            this.dataGridView_test = new System.Windows.Forms.DataGridView();
            this.label_learning = new System.Windows.Forms.Label();
            this.label_test = new System.Windows.Forms.Label();
            this.label_learningError = new System.Windows.Forms.Label();
            this.label_testError = new System.Windows.Forms.Label();
            this.label_criticalCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_learning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_test)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_learning
            // 
            this.dataGridView_learning.AllowUserToAddRows = false;
            this.dataGridView_learning.AllowUserToDeleteRows = false;
            this.dataGridView_learning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_learning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_learning.Location = new System.Drawing.Point(50, 75);
            this.dataGridView_learning.Name = "dataGridView_learning";
            this.dataGridView_learning.ReadOnly = true;
            this.dataGridView_learning.Size = new System.Drawing.Size(356, 530);
            this.dataGridView_learning.TabIndex = 0;
            // 
            // dataGridView_test
            // 
            this.dataGridView_test.AllowUserToAddRows = false;
            this.dataGridView_test.AllowUserToDeleteRows = false;
            this.dataGridView_test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_test.Location = new System.Drawing.Point(755, 75);
            this.dataGridView_test.Name = "dataGridView_test";
            this.dataGridView_test.ReadOnly = true;
            this.dataGridView_test.Size = new System.Drawing.Size(340, 530);
            this.dataGridView_test.TabIndex = 1;
            this.dataGridView_test.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_test_DataBindingComplete);
            // 
            // label_learning
            // 
            this.label_learning.AutoSize = true;
            this.label_learning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_learning.Location = new System.Drawing.Point(200, 45);
            this.label_learning.Name = "label_learning";
            this.label_learning.Size = new System.Drawing.Size(209, 25);
            this.label_learning.TabIndex = 2;
            this.label_learning.Text = "Обущающая выборка";
            // 
            // label_test
            // 
            this.label_test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_test.AutoSize = true;
            this.label_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_test.Location = new System.Drawing.Point(750, 45);
            this.label_test.Name = "label_test";
            this.label_test.Size = new System.Drawing.Size(181, 25);
            this.label_test.TabIndex = 3;
            this.label_test.Text = "Тестовая выборка";
            // 
            // label_learningError
            // 
            this.label_learningError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_learningError.AutoSize = true;
            this.label_learningError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_learningError.Location = new System.Drawing.Point(325, 610);
            this.label_learningError.Name = "label_learningError";
            this.label_learningError.Size = new System.Drawing.Size(81, 25);
            this.label_learningError.TabIndex = 4;
            this.label_learningError.Text = "ошибка";
            // 
            // label_testError
            // 
            this.label_testError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_testError.AutoSize = true;
            this.label_testError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_testError.Location = new System.Drawing.Point(921, 610);
            this.label_testError.Name = "label_testError";
            this.label_testError.Size = new System.Drawing.Size(81, 25);
            this.label_testError.TabIndex = 5;
            this.label_testError.Text = "ошибка";
            // 
            // label_criticalCount
            // 
            this.label_criticalCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label_criticalCount.AutoSize = true;
            this.label_criticalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_criticalCount.Location = new System.Drawing.Point(500, 610);
            this.label_criticalCount.Name = "label_criticalCount";
            this.label_criticalCount.Size = new System.Drawing.Size(349, 25);
            this.label_criticalCount.TabIndex = 6;
            this.label_criticalCount.Text = "Количество критических примеров ";
            // 
            // EvaluateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 716);
            this.Controls.Add(this.label_criticalCount);
            this.Controls.Add(this.label_testError);
            this.Controls.Add(this.label_learningError);
            this.Controls.Add(this.label_test);
            this.Controls.Add(this.label_learning);
            this.Controls.Add(this.dataGridView_test);
            this.Controls.Add(this.dataGridView_learning);
            this.Name = "EvaluateForm";
            this.Text = "EvaluateForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_learning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_learning;
        private System.Windows.Forms.DataGridView dataGridView_test;
        private System.Windows.Forms.Label label_learning;
        private System.Windows.Forms.Label label_test;
        private System.Windows.Forms.Label label_learningError;
        private System.Windows.Forms.Label label_testError;
        private System.Windows.Forms.Label label_criticalCount;
    }
}