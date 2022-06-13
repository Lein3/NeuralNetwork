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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Desription2 = new System.Windows.Forms.Label();
            this.label_Description = new System.Windows.Forms.Label();
            this.label_Description3 = new System.Windows.Forms.LinkLabel();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView_Test = new System.Windows.Forms.DataGridView();
            this.dataGridView_Learning = new System.Windows.Forms.DataGridView();
            this.label_Learning = new System.Windows.Forms.Label();
            this.panel_TestDescription = new System.Windows.Forms.Panel();
            this.label_Test = new System.Windows.Forms.Label();
            this.panel_Top.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learning)).BeginInit();
            this.panel_TestDescription.SuspendLayout();
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(515, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 732);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.dataGridView_Test, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.dataGridView_Learning, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.label_Learning, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.panel_TestDescription, 0, 2);
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Test.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Test.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Test.EnableHeadersVisualStyles = false;
            this.dataGridView_Test.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dataGridView_Test.Location = new System.Drawing.Point(3, 409);
            this.dataGridView_Test.Name = "dataGridView_Test";
            this.dataGridView_Test.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Test.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_Test.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Test.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView_Test.Size = new System.Drawing.Size(509, 320);
            this.dataGridView_Test.TabIndex = 56;
            this.dataGridView_Test.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Test_DataBindingComplete);
            // 
            // dataGridView_Learning
            // 
            this.dataGridView_Learning.AllowUserToOrderColumns = true;
            this.dataGridView_Learning.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dataGridView_Learning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Learning.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Learning.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView_Learning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Learning.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView_Learning.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_Learning.EnableHeadersVisualStyles = false;
            this.dataGridView_Learning.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.dataGridView_Learning.Location = new System.Drawing.Point(3, 28);
            this.dataGridView_Learning.Name = "dataGridView_Learning";
            this.dataGridView_Learning.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Learning.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView_Learning.RowHeadersVisible = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView_Learning.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_Learning.Size = new System.Drawing.Size(509, 319);
            this.dataGridView_Learning.TabIndex = 55;
            this.dataGridView_Learning.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView_Learning_DataBindingComplete);
            // 
            // label_Learning
            // 
            this.label_Learning.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Learning.ForeColor = System.Drawing.Color.White;
            this.label_Learning.Location = new System.Drawing.Point(3, 0);
            this.label_Learning.Name = "label_Learning";
            this.label_Learning.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label_Learning.Size = new System.Drawing.Size(431, 25);
            this.label_Learning.TabIndex = 53;
            this.label_Learning.Text = "Обучающая выборка";
            // 
            // panel_TestDescription
            // 
            this.panel_TestDescription.Controls.Add(this.label_Test);
            this.panel_TestDescription.Location = new System.Drawing.Point(3, 353);
            this.panel_TestDescription.Name = "panel_TestDescription";
            this.panel_TestDescription.Size = new System.Drawing.Size(431, 50);
            this.panel_TestDescription.TabIndex = 57;
            // 
            // label_Test
            // 
            this.label_Test.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Test.ForeColor = System.Drawing.Color.White;
            this.label_Test.Location = new System.Drawing.Point(3, 11);
            this.label_Test.Name = "label_Test";
            this.label_Test.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.label_Test.Size = new System.Drawing.Size(400, 38);
            this.label_Test.TabIndex = 54;
            this.label_Test.Text = "Тестовая выборка";
            // 
            // EvaluateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 832);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Top);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EvaluateForm";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Test)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Learning)).EndInit();
            this.panel_TestDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Desription2;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.LinkLabel label_Description3;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridView dataGridView_Test;
        private System.Windows.Forms.DataGridView dataGridView_Learning;
        private System.Windows.Forms.Label label_Learning;
        private System.Windows.Forms.Panel panel_TestDescription;
        private System.Windows.Forms.Label label_Test;
    }
}