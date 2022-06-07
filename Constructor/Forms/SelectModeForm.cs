using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using Constructor.Properties;

namespace Constructor
{
    public partial class SelectModeForm : Form
    {
        public SelectModeForm()
        {
            InitializeComponent();
            this.Icon = Resources.main;

            //так сделано чтобы в конструкторе все было четко видно
            this.Size = this.MinimumSize;
            panel_Authorization.Top -= 100;
            label_Authorization.Top -= 100;

            new List<Control> { panel_Top, panel_UserInfo, pictureBox_UserPicture, label_Username }.ForEach(x =>
            {
                x.MouseDown += (object s, MouseEventArgs e) =>
                {
                    x.Capture = false;
                    Capture = false;
                    Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                    base.WndProc(ref m);
                };
            });
        }

        #region Description
        private void DescriptionFunction(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "button_MyModels":
                    SetDescription(null);
                    break;
                case "button_MyDatasets":
                    SetDescription(null);
                    break;
                case "button_LoadModel":
                    SetDescription(null);
                    break;
                case "button_AutoMode":
                    SetDescription(Resources.AutoModeExplanation);
                    break;
                case "button_ProfessionalMode":
                    SetDescription(Resources.ProfessionalModeExplanation);
                    break;
                case "button_FreeMode":
                    SetDescription(Resources.FreeModeExplanation);
                    break;
            }
        }

        private void SetDescription(string Value)
        {
            label_Explanation.Text = Value;
        }
        #endregion

        #region ControlBox
        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Animation
        private async void linkLabel_ShowRegistration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            while (panel_Authorization.Location.Y < 500)
            {
                await Task.Delay(1);
                panel_Authorization.Location = new Point(panel_Authorization.Location.X, panel_Authorization.Location.Y + 12);
                label_Authorization.Location = new Point(label_Authorization.Location.X, label_Authorization.Location.Y + 12);
                panel_Registration.Location = new Point(panel_Registration.Location.X, panel_Registration.Location.Y - 12);
                label_Registration.Location = new Point(label_Registration.Location.X, label_Registration.Location.Y - 12);
            }
        }

        private async void linkLabel_ShowAuthorization_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            while (panel_Registration.Location.Y < 500)
            {
                await Task.Delay(1);
                panel_Authorization.Location = new Point(panel_Authorization.Location.X, panel_Authorization.Location.Y - 12);
                label_Authorization.Location = new Point(label_Authorization.Location.X, label_Authorization.Location.Y - 12);
                panel_Registration.Location = new Point(panel_Registration.Location.X, panel_Registration.Location.Y + 12);
                label_Registration.Location = new Point(label_Registration.Location.X, label_Registration.Location.Y + 12);
            }
        }
        #endregion

        #region AuthorizationRegistration
        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            //TODO: сделать авторизацию
            AuthorizationVisibility();
            label_Username.Text = "Привет, АШОТ-КАМШОТ";
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            //TODO: сделать регистрацию
            AuthorizationVisibility();
            label_Username.Text = "Привет, АШОТ-КАМШОТ";
        }

        private void AuthorizationVisibility()
        {
            panel_Authorization.Visible = false;
            label_Authorization.Visible = false;
            panel_Registration.Visible = false;
            label_Registration.Visible = false;
            button_MyModels.Visible = true;
            button_MyDatasets.Visible = true;
        }
        #endregion
    }
}
