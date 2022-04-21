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
    public partial class MainForm : Form
    {
        private new Form ActiveForm { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateInputLayerForm());
        }

        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null) ActiveForm.Close();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Screen.Controls.Clear();
            panel_Screen.Controls.Add(childForm);
            panel_Screen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
