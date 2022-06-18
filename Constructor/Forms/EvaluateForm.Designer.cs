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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Desription2 = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Description3 = new System.Windows.Forms.LinkLabel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_Predict = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Test = new System.Windows.Forms.DataGridView();
            this.panel_TestDescription = new System.Windows.Forms.Panel();
            this.label_Test = new System.Windows.Forms.Label();
            this.dataGridView_Learning = new System.Windows.Forms.DataGridView();
            this.panel_LearningDescription = new System.Windows.Forms.Panel();
            this.label_Learning = new System.Windows.Forms.Label();
            this.label_datasetInfo = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).BeginInit();
            this.panel_TestDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learning)).BeginInit();
            this.panel_LearningDescription.SuspendLayout();
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
            this.panel_Top.Controls.Add(this.label_datasetInfo);
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
            // dataGridView_Test
            // 
            this.dataGridView_Test.AllowUserToOrderColumns = true;
            this.dataGridView_Test.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView_Test.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Test.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Test.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView_Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Test.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView_Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Test.EnableHeadersVisualStyles = false;
            this.dataGridView_Test.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dataGridView_Test.Location = new System.Drawing.Point(3, 445);
            this.dataGridView_Test.Name = "dataGridView_Test";
            this.dataGridView_Test.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Test.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView_Test.RowHeadersVisible = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Test.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridView_Test.Size = new System.Drawing.Size(509, 284);
            this.dataGridView_Test.TabIndex = 61;
            this.dataGridView_Test.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Test_DataBindingComplete);
            // 
            // panel_TestDescription
            // 
            this.panel_TestDescription.Controls.Add(this.label_Test);
            this.panel_TestDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TestDescription.Location = new System.Drawing.Point(3, 369);
            this.panel_TestDescription.Name = "panel_TestDescription";
            this.panel_TestDescription.Size = new System.Drawing.Size(509, 70);
            this.panel_TestDescription.TabIndex = 60;
            // 
            // label_Test
            // 
            this.label_Test.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Test.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Test.ForeColor = System.Drawing.Color.White;
            this.label_Test.Location = new System.Drawing.Point(3, 10);
            this.label_Test.Name = "label_Test";
            this.label_Test.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label_Test.Size = new System.Drawing.Size(475, 50);
            this.label_Test.TabIndex = 54;
            this.label_Test.Text = "Тестовая выборка";
            // 
            // dataGridView_Learning
            // 
            this.dataGridView_Learning.AllowUserToOrderColumns = true;
            this.dataGridView_Learning.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView_Learning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Learning.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Learning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridView_Learning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Learning.DefaultCellStyle = dataGridViewCellStyle30;
            this.dataGridView_Learning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Learning.EnableHeadersVisualStyles = false;
            this.dataGridView_Learning.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dataGridView_Learning.Location = new System.Drawing.Point(3, 79);
            this.dataGridView_Learning.Name = "dataGridView_Learning";
            this.dataGridView_Learning.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Learning.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView_Learning.RowHeadersVisible = false;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Learning.RowsDefaultCellStyle = dataGridViewCellStyle32;
            this.dataGridView_Learning.Size = new System.Drawing.Size(509, 284);
            this.dataGridView_Learning.TabIndex = 59;
            this.dataGridView_Learning.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Learning_DataBindingComplete);
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
            this.label_Learning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Learning.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Learning.ForeColor = System.Drawing.Color.White;
            this.label_Learning.Location = new System.Drawing.Point(3, 10);
            this.label_Learning.Name = "label_Learning";
            this.label_Learning.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label_Learning.Size = new System.Drawing.Size(475, 50);
            this.label_Learning.TabIndex = 54;
            this.label_Learning.Text = "Обучающая выборка";
            // 
            // label_datasetInfo
            // 
            this.label_datasetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_datasetInfo.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_datasetInfo.ForeColor = System.Drawing.Color.White;
            this.label_datasetInfo.Location = new System.Drawing.Point(450, 10);
            this.label_datasetInfo.Name = "label_datasetInfo";
            this.label_datasetInfo.Size = new System.Drawing.Size(320, 80);
            this.label_datasetInfo.TabIndex = 6;
            this.label_datasetInfo.Text = "Изначально в наборе данных\r\n";
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).EndInit();
            this.panel_TestDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learning)).EndInit();
            this.panel_LearningDescription.ResumeLayout(false);
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
        private System.Windows.Forms.Label label_Test;
        private System.Windows.Forms.DataGridView dataGridView_Learning;
        private System.Windows.Forms.Label label_datasetInfo;
    }
}