using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using static Constructor.Properties.Resources;

namespace Constructor
{
    public partial class SelectModeForm : Form
    {
        public SelectModeForm()
        {
            InitializeComponent();
            new List<Control> { panel_Top, UserInfoPanel, UserProfilePicture, Username }.ForEach(x =>
            {
                x.MouseDown += (s, e) =>
                {
                    x.Capture = false;
                    Capture = false;
                    Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                    base.WndProc(ref m);
                };
            });
        }

        #region Description
        /// <summary>
        /// ТУТ БЛЯТЬ КОРОЧЕ БЕРЕТСЯ ТЕКСТ ИЗ РЕСУРСОВ ПРИ НАВЕДЕНИИ НА КНОПКИ ЕПТА
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void DescriptionFunction(object sender, EventArgs e)
        {
            try
            {
                switch ((sender as Button).Name)
                {
                    case "AutoModeButton":
                        SetDescription(AutoModeExplanation);
                        break;
                    case "ProfessionalModeButton":
                        SetDescription(ProfessionalModeExplanation);
                        break;
                    case "FreedomModeButton":
                        SetDescription(FullFreedomModeExplanation);
                        break;
                    case "LoadModelsButton":
                        SetDescription("Загрузка типо модели");
                        break;
                    case "UserModelsButton":
                        SetDescription("Отобразить сохраненные модели");
                        break;
                    case "AuthorizationButton":
                        SetDescription("я не насрал");
                        break;
                    case "RegistrationButton":
                        SetDescription("я насрал");
                        break;
                }
            }
            catch
            {
                switch ((sender as LinkLabel).Name)
                {
                    case "ShowAuthorizationPanel":
                        SetDescription("Открыть окно регистрации");
                        break;
                    case "ShowRegistrationPanel":
                        SetDescription("Открыть окно авторизации");
                        break;
                }
            }
        }

        private void SetDescription(string Value)
        {
            label_Explanation.Text = Value;
        }
        #endregion

        #region ControlBox
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Animation
        private async void ShowAuthorizationPanel_Click(object sender, EventArgs e)
        {
            while (RegistrationPanel.Location.X > -300)
            {
                await Task.Delay(1);
                //
                RegistrationPanel.Location = new Point(RegistrationPanel.Location.X - 12, RegistrationPanel.Location.Y);
                RegistrationLabel.Location = new Point(RegistrationLabel.Location.X - 12, RegistrationLabel.Location.Y);
                //
                AuthorizationPanel.Location = new Point(AuthorizationPanel.Location.X + 12, AuthorizationPanel.Location.Y);
                AuthorizationLabel.Location = new Point(AuthorizationLabel.Location.X + 12, AuthorizationLabel.Location.Y);
            }
            AuthorizationPanel.Location = new Point(28, AuthorizationPanel.Location.Y);
            AuthorizationLabel.Location = new Point(39, AuthorizationLabel.Location.Y);
        }

        private async void ShowRegistrationPanel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            while (AuthorizationPanel.Location.X > -300)
            {
                await Task.Delay(1);
                //
                AuthorizationPanel.Location = new Point(AuthorizationPanel.Location.X - 12, AuthorizationPanel.Location.Y);
                AuthorizationLabel.Location = new Point(AuthorizationLabel.Location.X - 12, AuthorizationLabel.Location.Y);
                //
                RegistrationPanel.Location = new Point(RegistrationPanel.Location.X + 12, RegistrationPanel.Location.Y);
                RegistrationLabel.Location = new Point(RegistrationLabel.Location.X + 12, RegistrationLabel.Location.Y);
            }
            RegistrationPanel.Location = new Point(28, RegistrationPanel.Location.Y);
            RegistrationLabel.Location = new Point(39, RegistrationLabel.Location.Y);
        }
        #endregion

        #region Authorization
        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            //
            AuthorizationVisibility();
            //
            Username.Text = "Привет, АШОТ-КАМШОТ";
        }

        private void AuthorizationVisibility()
        {
            AuthorizationPanel.Visible = false;
            AuthorizationLabel.Visible = false;
            RegistrationPanel.Visible = false;
            RegistrationLabel.Visible = false;
            UserModelsButton.Visible = true;
        }
        #endregion
    }
}
