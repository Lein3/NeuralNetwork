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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Desription2 = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Description3 = new System.Windows.Forms.LinkLabel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Predict = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel_LearningDescription = new System.Windows.Forms.Panel();
            this.label_Learning = new System.Windows.Forms.Label();
            this.dataGridView_Learning = new System.Windows.Forms.DataGridView();
            this.panel_TestDescription = new System.Windows.Forms.Panel();
            this.labelTest = new System.Windows.Forms.Label();
            this.dataGridView_Test = new System.Windows.Forms.DataGridView();
            this.panel_Top.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.panel_LearningDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learning)).BeginInit();
            this.panel_TestDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Desription2
            // 
            this.label_Desription2.AutoSize = true;
            this.label_Desription2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Desription2.ForeColor = System.Drawing.Color.White;
            this.label_Desription2.Location = new System.Drawing.Point(12, 45);
            this.label_Desription2.Name = "label_Desription2";
            this.label_Desription2.Size = new System.Drawing.Size(385, 19);
            this.label_Desription2.TabIndex = 4;
            this.label_Desription2.Text = "Результаты обучения вашей модели приведены ниже";
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.ForeColor = System.Drawing.Color.White;
            this.label_Description.Location = new System.Drawing.Point(10, 5);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(218, 30);
            this.label_Description.TabIndex = 3;
            this.label_Description.Text = "Оценка обучения";
            // 
            // label_Description3
            // 
            this.label_Description3.ActiveLinkColor = System.Drawing.Color.White;
            this.label_Description3.AutoSize = true;
            this.label_Description3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label_Description3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(174)))), ((int)(((byte)(199)))));
            this.label_Description3.Location = new System.Drawing.Point(12, 70);
            this.label_Description3.Name = "label_Description3";
            this.label_Description3.Size = new System.Drawing.Size(254, 17);
            this.label_Description3.TabIndex = 5;
            this.label_Description3.TabStop = true;
            this.label_Description3.Text = "Как оценить эффективность модели?";
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.label_Description);
            this.panel_Top.Controls.Add(this.label_Desription2);
            this.panel_Top.Controls.Add(this.label_Description3);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(800, 100);
            this.panel_Top.TabIndex = 7;
            // 
            // panel_Predict
            // 
            this.panel_Predict.AutoScroll = true;
            this.panel_Predict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel_Predict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Predict.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Predict.Location = new System.Drawing.Point(515, 100);
            this.panel_Predict.Name = "panel_Predict";
            this.panel_Predict.Size = new System.Drawing.Size(285, 732);
            this.panel_Predict.TabIndex = 8;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dataGridView_Test, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.panel_TestDescription, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.dataGridView_Learning, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.panel_LearningDescription, 0, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(515, 732);
            this.tableLayoutPanel.TabIndex = 9;
            // 
            // panel_LearningDescription
            // 
            this.panel_LearningDescription.Controls.Add(this.label_Learning);
            this.panel_LearningDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_LearningDescription.Location = new System.Drawing.Point(3, 3);
            this.panel_LearningDescription.Name = "panel_LearningDescription";
            this.panel_LearningDescription.Size = new System.Drawing.Size(509, 70);
            this.panel_LearningDescription.TabIndex = 58;
            // 
            // label_Learning
            // 
            this.label_Learning.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Learning.ForeColor = System.Drawing.Color.White;
            this.label_Learning.Location = new System.Drawing.Point(3, 15);
            this.label_Learning.Name = "label_Learning";
            this.label_Learning.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label_Learning.Size = new System.Drawing.Size(400, 30);
            this.label_Learning.TabIndex = 54;
            this.label_Learning.Text = "Тестовая выборка";
            // 
            // dataGridView_Learning
            // 
            this.dataGridView_Learning.AllowUserToOrderColumns = true;
            this.dataGridView_Learning.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView_Learning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Learning.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Learning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_Learning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Learning.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_Learning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Learning.EnableHeadersVisualStyles = false;
            this.dataGridView_Learning.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dataGridView_Learning.Location = new System.Drawing.Point(3, 79);
            this.dataGridView_Learning.Name = "dataGridView_Learning";
            this.dataGridView_Learning.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Learning.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView_Learning.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Learning.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView_Learning.Size = new System.Drawing.Size(509, 284);
            this.dataGridView_Learning.TabIndex = 59;
            // 
            // panel_TestDescription
            // 
            this.panel_TestDescription.Controls.Add(this.labelTest);
            this.panel_TestDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TestDescription.Location = new System.Drawing.Point(3, 369);
            this.panel_TestDescription.Name = "panel_TestDescription";
            this.panel_TestDescription.Size = new System.Drawing.Size(509, 70);
            this.panel_TestDescription.TabIndex = 60;
            // 
            // labelTest
            // 
            this.labelTest.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTest.ForeColor = System.Drawing.Color.White;
            this.labelTest.Location = new System.Drawing.Point(3, 15);
            this.labelTest.Name = "labelTest";
            this.labelTest.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.labelTest.Size = new System.Drawing.Size(400, 30);
            this.labelTest.TabIndex = 54;
            this.labelTest.Text = "Тестовая выборка";
            // 
            // dataGridView_Test
            // 
            this.dataGridView_Test.AllowUserToOrderColumns = true;
            this.dataGridView_Test.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView_Test.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Test.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Test.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Test.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Test.EnableHeadersVisualStyles = false;
            this.dataGridView_Test.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dataGridView_Test.Location = new System.Drawing.Point(3, 445);
            this.dataGridView_Test.Name = "dataGridView_Test";
            this.dataGridView_Test.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Test.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_Test.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Test.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_Test.Size = new System.Drawing.Size(509, 284);
            this.dataGridView_Test.TabIndex = 61;
            // 
            // EvaluateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 832);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panel_Predict);
            this.Controls.Add(this.panel_Top);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EvaluateForm";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            this.panel_LearningDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learning)).EndInit();
            this.panel_TestDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Desription2;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.LinkLabel label_Description3;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_Predict;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel panel_LearningDescription;
        private System.Windows.Forms.Label label_Learning;
        private System.Windows.Forms.DataGridView dataGridView_Test;
        private System.Windows.Forms.Panel panel_TestDescription;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.DataGridView dataGridView_Learning;
    }
}