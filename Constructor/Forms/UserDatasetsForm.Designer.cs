namespace Constructor
{
    partial class UserDatasetsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDatasetsForm));
            this.panel_Top = new System.Windows.Forms.Panel();
            this.panel_UserInfo = new System.Windows.Forms.Panel();
            this.label_Username = new System.Windows.Forms.Label();
            this.pictureBox_UserPicture = new System.Windows.Forms.PictureBox();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panel_Top.SuspendLayout();
            this.panel_UserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.panel_UserInfo);
            this.panel_Top.Controls.Add(this.button_Minimize);
            this.panel_Top.Controls.Add(this.button_Close);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(650, 50);
            this.panel_Top.TabIndex = 0;
            // 
            // panel_UserInfo
            // 
            this.panel_UserInfo.Controls.Add(this.label_Username);
            this.panel_UserInfo.Controls.Add(this.pictureBox_UserPicture);
            this.panel_UserInfo.Location = new System.Drawing.Point(12, 13);
            this.panel_UserInfo.Name = "panel_UserInfo";
            this.panel_UserInfo.Size = new System.Drawing.Size(219, 25);
            this.panel_UserInfo.TabIndex = 15;
            // 
            // label_Username
            // 
            this.label_Username.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_Username.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.label_Username.ForeColor = System.Drawing.Color.White;
            this.label_Username.Location = new System.Drawing.Point(34, 0);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(185, 25);
            this.label_Username.TabIndex = 14;
            this.label_Username.Text = "Анонимный пользователь";
            this.label_Username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_UserPicture
            // 
            this.pictureBox_UserPicture.BackgroundImage = global::Constructor.Properties.Resources.User;
            this.pictureBox_UserPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_UserPicture.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_UserPicture.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_UserPicture.Name = "pictureBox_UserPicture";
            this.pictureBox_UserPicture.Size = new System.Drawing.Size(34, 25);
            this.pictureBox_UserPicture.TabIndex = 15;
            this.pictureBox_UserPicture.TabStop = false;
            // 
            // button_Minimize
            // 
            this.button_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Minimize.BackgroundImage = global::Constructor.Properties.Resources.btnMinimize;
            this.button_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Location = new System.Drawing.Point(570, 15);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(30, 25);
            this.button_Minimize.TabIndex = 13;
            this.button_Minimize.UseVisualStyleBackColor = false;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button_Close.BackgroundImage = global::Constructor.Properties.Resources.btnClose;
            this.button_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F);
            this.button_Close.Location = new System.Drawing.Point(610, 15);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(30, 25);
            this.button_Close.TabIndex = 12;
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.AutoScroll = true;
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(0, 50);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(650, 350);
            this.panel_Main.TabIndex = 1;
            // 
            // UserDatasetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.ControlBox = false;
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Top);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "UserDatasetsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мои наборы данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserDatasetsForm_FormClosed);
            this.panel_Top.ResumeLayout(false);
            this.panel_UserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_UserPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Panel panel_UserInfo;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.PictureBox pictureBox_UserPicture;
        private System.Windows.Forms.Button button_Minimize;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Panel panel_Main;
    }
}