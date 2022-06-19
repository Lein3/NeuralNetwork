using NeuralNetworkNamespace;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Constructor
{
    public partial class UserModelsForm : Form
    {
        public AuthorizationForm PreviousForm { get; set; }
        public UserModelsForm()
        {
            InitializeComponent();
            if (GlobalTemplate.CurrentUser == null)
            {
                return;
            }
            label_Username.Text = "Здравствуйте, " + GlobalTemplate.CurrentUser.Login;
            foreach (var network in Connection.db.Value.NeuralNetworks.Where(item => item.Owner == GlobalTemplate.CurrentUser.ID))
            {
                var control = new UserModelControl(network);
                control.BackColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                control.BorderStyle = BorderStyle.FixedSingle;
                control.ForeColor = Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
                control.Margin = new Padding(27);
                control.MinimumSize = new Size(2, 100);
                control.Size = new Size(250, 290);
                control.DoubleClick += CustomDoubleClick;
                flowLayoutPanel.Controls.Add(control);
            }
        }

        #region ControlBox
        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            PreviousForm.Opacity = 1;
            this.Close();
        }
        #endregion

        private void UserDatasetsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PreviousForm.Opacity = 1;
            this.Close();
        }

        private void CustomDoubleClick(object sender, EventArgs e)
        {
            var control = sender as UserModelControl;
            var neuralNetwork = JsonConvert.DeserializeObject<NeuralNetwork>(control.NeuralNetworks.SerializedString, AuthorizationForm.settings);

            GlobalTemplate.NeuralNetwork = neuralNetwork;
            GlobalTemplate.DatabaseNeuralNetwork = control.NeuralNetworks;

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
