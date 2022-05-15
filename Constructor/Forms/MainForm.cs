using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateInputLayerForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateMiddleLayersForm());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LearningForm());
        }

        public void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EvaluateForm());
        }
    }
}
