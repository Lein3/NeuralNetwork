using System;
using System.Windows.Forms;
using System.Linq;

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
            //panel_Screen.Controls.Clear();
            //panel_Screen.Controls.Add(childForm);
            //panel_Screen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ReColorButtons(Button currentButton)
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = System.Drawing.ColorTranslator.FromHtml("#333333");
            }
            currentButton.BackColor = System.Drawing.ColorTranslator.FromHtml("#666666");
        }

        private void button_Click(object sender, EventArgs e)
        {
            ReColorButtons(sender as Button);
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
