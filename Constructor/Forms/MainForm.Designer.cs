namespace Constructor
{
    partial class MainForm
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
            this.button_Scenario = new System.Windows.Forms.Button();
            this.button_Data = new System.Windows.Forms.Button();
            this.button_Learning = new System.Windows.Forms.Button();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Screen = new System.Windows.Forms.Panel();
            this.button_Configuration = new System.Windows.Forms.Button();
            this.button_InputLayer = new System.Windows.Forms.Button();
            this.button_MiddleLayers = new System.Windows.Forms.Button();
            this.button_OutputLayer = new System.Windows.Forms.Button();
            this.panel_Configuration = new System.Windows.Forms.Panel();
            this.button_LayersReady = new System.Windows.Forms.Button();
            this.panel_Left = new System.Windows.Forms.Panel();
            this.panel_Configuration.SuspendLayout();
            this.panel_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Scenario
            // 
            this.button_Scenario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Scenario.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Scenario.FlatAppearance.BorderSize = 0;
            this.button_Scenario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Scenario.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Scenario.ForeColor = System.Drawing.Color.White;
            this.button_Scenario.Location = new System.Drawing.Point(0, 0);
            this.button_Scenario.Margin = new System.Windows.Forms.Padding(0);
            this.button_Scenario.Name = "button_Scenario";
            this.button_Scenario.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_Scenario.Size = new System.Drawing.Size(170, 30);
            this.button_Scenario.TabIndex = 0;
            this.button_Scenario.Text = "Сценарий";
            this.button_Scenario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Scenario.UseVisualStyleBackColor = false;
            this.button_Scenario.Click += new System.EventHandler(this.button_Scenario_Click);
            // 
            // button_Data
            // 
            this.button_Data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Data.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Data.Enabled = false;
            this.button_Data.FlatAppearance.BorderSize = 0;
            this.button_Data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Data.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Data.ForeColor = System.Drawing.Color.White;
            this.button_Data.Location = new System.Drawing.Point(0, 30);
            this.button_Data.Margin = new System.Windows.Forms.Padding(0);
            this.button_Data.Name = "button_Data";
            this.button_Data.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_Data.Size = new System.Drawing.Size(170, 30);
            this.button_Data.TabIndex = 2;
            this.button_Data.Text = "Данные";
            this.button_Data.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Data.UseVisualStyleBackColor = false;
            this.button_Data.Click += new System.EventHandler(this.button_Data_Click);
            // 
            // button_Learning
            // 
            this.button_Learning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Learning.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Learning.FlatAppearance.BorderSize = 0;
            this.button_Learning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Learning.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Learning.ForeColor = System.Drawing.Color.White;
            this.button_Learning.Location = new System.Drawing.Point(0, 210);
            this.button_Learning.Margin = new System.Windows.Forms.Padding(0);
            this.button_Learning.Name = "button_Learning";
            this.button_Learning.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_Learning.Size = new System.Drawing.Size(170, 29);
            this.button_Learning.TabIndex = 3;
            this.button_Learning.Text = "Обучение";
            this.button_Learning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Learning.UseVisualStyleBackColor = false;
            this.button_Learning.Click += new System.EventHandler(this.button_Learning_Click);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Minimize.BackgroundImage = global::Constructor.Properties.Resources.btnMinimize;
            this.button_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Location = new System.Drawing.Point(725, 5);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(30, 25);
            this.button_Minimize.TabIndex = 15;
            this.button_Minimize.UseVisualStyleBackColor = false;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Close.BackgroundImage = global::Constructor.Properties.Resources.btnClose;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Location = new System.Drawing.Point(760, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 25);
            this.button_Close.TabIndex = 14;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel_Screen
            // 
            this.panel_Screen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Screen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel_Screen.Location = new System.Drawing.Point(215, 40);
            this.panel_Screen.Name = "panel_Screen";
            this.panel_Screen.Size = new System.Drawing.Size(570, 450);
            this.panel_Screen.TabIndex = 16;
            // 
            // button_Configuration
            // 
            this.button_Configuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Configuration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Configuration.Enabled = false;
            this.button_Configuration.FlatAppearance.BorderSize = 0;
            this.button_Configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Configuration.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Configuration.ForeColor = System.Drawing.Color.White;
            this.button_Configuration.Location = new System.Drawing.Point(0, 60);
            this.button_Configuration.Margin = new System.Windows.Forms.Padding(0);
            this.button_Configuration.Name = "button_Configuration";
            this.button_Configuration.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_Configuration.Size = new System.Drawing.Size(170, 30);
            this.button_Configuration.TabIndex = 17;
            this.button_Configuration.Text = "Конфигурация сети";
            this.button_Configuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Configuration.UseVisualStyleBackColor = false;
            this.button_Configuration.Click += new System.EventHandler(this.button_Configuration_Click);
            // 
            // button_InputLayer
            // 
            this.button_InputLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_InputLayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_InputLayer.FlatAppearance.BorderSize = 0;
            this.button_InputLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InputLayer.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_InputLayer.ForeColor = System.Drawing.Color.White;
            this.button_InputLayer.Location = new System.Drawing.Point(0, 0);
            this.button_InputLayer.Margin = new System.Windows.Forms.Padding(0);
            this.button_InputLayer.Name = "button_InputLayer";
            this.button_InputLayer.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button_InputLayer.Size = new System.Drawing.Size(170, 30);
            this.button_InputLayer.TabIndex = 18;
            this.button_InputLayer.Text = "Входной слой";
            this.button_InputLayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_InputLayer.UseVisualStyleBackColor = false;
            // 
            // button_MiddleLayers
            // 
            this.button_MiddleLayers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_MiddleLayers.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_MiddleLayers.FlatAppearance.BorderSize = 0;
            this.button_MiddleLayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MiddleLayers.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MiddleLayers.ForeColor = System.Drawing.Color.White;
            this.button_MiddleLayers.Location = new System.Drawing.Point(0, 30);
            this.button_MiddleLayers.Margin = new System.Windows.Forms.Padding(0);
            this.button_MiddleLayers.Name = "button_MiddleLayers";
            this.button_MiddleLayers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button_MiddleLayers.Size = new System.Drawing.Size(170, 30);
            this.button_MiddleLayers.TabIndex = 19;
            this.button_MiddleLayers.Text = "Скрытые слои";
            this.button_MiddleLayers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_MiddleLayers.UseVisualStyleBackColor = false;
            // 
            // button_OutputLayer
            // 
            this.button_OutputLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_OutputLayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_OutputLayer.FlatAppearance.BorderSize = 0;
            this.button_OutputLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OutputLayer.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OutputLayer.ForeColor = System.Drawing.Color.White;
            this.button_OutputLayer.Location = new System.Drawing.Point(0, 60);
            this.button_OutputLayer.Margin = new System.Windows.Forms.Padding(0);
            this.button_OutputLayer.Name = "button_OutputLayer";
            this.button_OutputLayer.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button_OutputLayer.Size = new System.Drawing.Size(170, 30);
            this.button_OutputLayer.TabIndex = 20;
            this.button_OutputLayer.Text = "Выходной слой";
            this.button_OutputLayer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OutputLayer.UseVisualStyleBackColor = false;
            // 
            // panel_Configuration
            // 
            this.panel_Configuration.Controls.Add(this.button_LayersReady);
            this.panel_Configuration.Controls.Add(this.button_OutputLayer);
            this.panel_Configuration.Controls.Add(this.button_MiddleLayers);
            this.panel_Configuration.Controls.Add(this.button_InputLayer);
            this.panel_Configuration.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Configuration.Location = new System.Drawing.Point(0, 90);
            this.panel_Configuration.Name = "panel_Configuration";
            this.panel_Configuration.Size = new System.Drawing.Size(170, 120);
            this.panel_Configuration.TabIndex = 21;
            this.panel_Configuration.Visible = false;
            // 
            // button_LayersReady
            // 
            this.button_LayersReady.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_LayersReady.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_LayersReady.Enabled = false;
            this.button_LayersReady.FlatAppearance.BorderSize = 0;
            this.button_LayersReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LayersReady.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_LayersReady.ForeColor = System.Drawing.Color.White;
            this.button_LayersReady.Location = new System.Drawing.Point(0, 90);
            this.button_LayersReady.Margin = new System.Windows.Forms.Padding(0);
            this.button_LayersReady.Name = "button_LayersReady";
            this.button_LayersReady.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button_LayersReady.Size = new System.Drawing.Size(170, 30);
            this.button_LayersReady.TabIndex = 22;
            this.button_LayersReady.Text = "Продолжить";
            this.button_LayersReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_LayersReady.UseVisualStyleBackColor = false;
            this.button_LayersReady.Click += new System.EventHandler(this.button_LayersReady_Click);
            // 
            // panel_Left
            // 
            this.panel_Left.Controls.Add(this.button_Learning);
            this.panel_Left.Controls.Add(this.panel_Configuration);
            this.panel_Left.Controls.Add(this.button_Configuration);
            this.panel_Left.Controls.Add(this.button_Data);
            this.panel_Left.Controls.Add(this.button_Scenario);
            this.panel_Left.Location = new System.Drawing.Point(39, 40);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(170, 448);
            this.panel_Left.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Screen);
            this.Controls.Add(this.button_Minimize);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.panel_Left);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.Text = "ОооКонструктор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel_Configuration.ResumeLayout(false);
            this.panel_Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Panel panel_Screen;
        public System.Windows.Forms.Button button_Scenario;
        public System.Windows.Forms.Button button_Data;
        public System.Windows.Forms.Button button_Learning;
        public System.Windows.Forms.Button button_Configuration;
        public System.Windows.Forms.Button button_InputLayer;
        public System.Windows.Forms.Button button_MiddleLayers;
        public System.Windows.Forms.Button button_OutputLayer;
        private System.Windows.Forms.Panel panel_Configuration;
        public System.Windows.Forms.Button button_LayersReady;
        private System.Windows.Forms.Panel panel_Left;
    }
}