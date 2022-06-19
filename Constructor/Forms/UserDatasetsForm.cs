using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class UserDatasetsForm : Form
    {
        public AuthorizationForm PreviousForm { get; set; }
        public UserDatasetsForm()
        {
            InitializeComponent();

            if (GlobalTemplate.CurrentUser == null)
            {
                return;
            }

            label_Username.Text = "Здравствуйте, " + GlobalTemplate.CurrentUser.Login;

            foreach (var dataset in Connection.db.Value.Datasets.Where(item => item.Owner == GlobalTemplate.CurrentUser.ID))
            {
                var control = new UserDatasetControl(dataset) { Dock = DockStyle.Top };
                panel_Main.Controls.Add(control);
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
    }
}
