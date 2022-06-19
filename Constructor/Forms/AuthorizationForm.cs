using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using Constructor.Properties;
using System.Linq;
using System.Data.SqlClient;
using Newtonsoft.Json;
using NeuralNetworkNamespace;
using System.IO;

namespace Constructor
{
    public partial class AuthorizationForm : Form
    {
        public int pashalka = 0;
        public int selectedDatasetID { get; set; }
        public AuthorizationForm()
        {
            InitializeComponent();
            this.Icon = Resources.mainIcon;

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

        #region Статические настройки для сериализатора
        public static JsonKnownTypesBinder SerializationBinder = new JsonKnownTypesBinder()
        {
            KnownTypes = new List<Type>()
                    {
                    typeof(BinaryLogLoss),
                    typeof(Sigmoid),
                    typeof(None),
                    typeof(Neuron_Bias),
                    typeof(Neuron_Input),
                    typeof(Neuron_Normal),
                    typeof(Neuron_Output),
                    }
        };

        public static JsonSerializerSettings settings = new JsonSerializerSettings() 
        { 
            TypeNameHandling = TypeNameHandling.Auto,
            SerializationBinder = SerializationBinder 
        };
        #endregion

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
            pashalka++;
            if (pashalka >= 4)
            {
                Size = new Size(700, 800);
            }
            if (pashalka == 6)
            {
                pictureBox_Pashalka.Image = Resources.пасхалка;
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
            var login = textBox_LoginAuthorization.Text;
            var password = HashingPassword.Hashing_Function(textBox_PasswordAuthorization.Text);
            var user = Connection.db.Value.Users.SingleOrDefault(item => item.Login == login && item.Password == password);
            if (user != null)
            {
                GlobalTemplate.CurrentUser = user;
                AuthorizationVisibility();
                label_Username.Text = "Здравствуйте, " + GlobalTemplate.CurrentUser.Login;
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
            }               
        }

        private void button_Registration_Click(object sender, EventArgs e)
        {
            if (Connection.db.Value.Users.Any(item => item.Login == textBox_LoginRegistration.Text))
            {
                MessageBox.Show("Логин уже занят");
                return;
            }

            var user = new Users() { Login = textBox_LoginRegistration.Text, Password = HashingPassword.Hashing_Function(textBox_PasswordRegistration.Text)};
            Connection.db.Value.Users.Add(user);
            Connection.db.Value.SaveChanges();
            GlobalTemplate.CurrentUser = user;

            AuthorizationVisibility();
            label_Username.Text = "Здравствуйте, " + GlobalTemplate.CurrentUser.Login;
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

        private void button_LoadModel_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog() { Filter = "NeuralConstructor Files (*.nc)|*.nc|JSON Files (*.json)|*.json|All files (*.*)|*.*" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog.FileName);
                var neural = JsonConvert.DeserializeObject<NeuralNetwork>(json, AuthorizationForm.settings);

                GlobalTemplate.NeuralNetwork = neural;
                GlobalTemplate.CurrentWorkMode = GlobalTemplate.WorkMode.professionalMode;
                GlobalTemplate.Loaded = true;

                var child = new MainForm() { PreviousForm = this };
                child.Show();
                child.button_Configuration_Click(null, null);
                child.button_Configuration.Enabled = true;
                child.button_InputLayer.Text = "Входной слой ✓";
                child.button_InputLayer.ForeColor = Color.FromArgb(85, 170, 255);
                child.button_MiddleLayers.Text = "Скрытые слои ✓";
                child.button_MiddleLayers.ForeColor = Color.FromArgb(85, 170, 255);
                child.button_OutputLayer.Text = "Выходной слой ✓";
                child.button_OutputLayer.ForeColor = Color.FromArgb(85, 170, 255);
                child.button_LayersReady.Enabled = true;
                this.Hide();
            }
        }

        private void button_AutoMode_Click(object sender, EventArgs e)
        {
            GlobalTemplate.CurrentWorkMode = GlobalTemplate.WorkMode.autoMode;
            new MainForm() { PreviousForm = this }.Show();
            this.Hide();
        }

        private void button_ProfessionalMode_Click(object sender, EventArgs e)
        {
            GlobalTemplate.CurrentWorkMode = GlobalTemplate.WorkMode.professionalMode;
            new MainForm() { PreviousForm = this }.Show();
            this.Hide();
        }

        private void button_FreeMode_Click(object sender, EventArgs e)
        {
            GlobalTemplate.CurrentWorkMode = GlobalTemplate.WorkMode.freeMode;
            new MainForm() { PreviousForm = this }.Show();
            this.Hide();
        }

        private void button_MyDatasets_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;
            if (new UserDatasetsForm() { PreviousForm = this }.ShowDialog() == DialogResult.OK)
            {
                GlobalTemplate.CurrentWorkMode = GlobalTemplate.WorkMode.professionalMode;
                GlobalTemplate.CurrentScenario = GlobalTemplate.Scenario.multiclassClassification;
                var child = new MainForm() { PreviousForm = this };
                child.Show();
                child.button_Data_Click(selectedDatasetID);
                child.button_Data.Enabled = true;
                this.Hide();
            }
        }
    }
}
