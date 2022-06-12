﻿using System;
using System.Windows.Forms;
using System.Linq;
using Constructor.Properties;
using System.Drawing;

namespace Constructor
{
    public partial class MainForm : Form
    {
        private new Form ActiveForm { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.Icon = Resources.mainIcon;
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.Click += Recolor_Click;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
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

        private void RecolorButtons(Button currentButton)
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.BackColor = Color.FromArgb(51, 51, 51);
            }
            currentButton.BackColor = Color.FromArgb(102, 102, 102);
        }

        private void Recolor_Click(object sender, EventArgs e)
        {
            RecolorButtons(sender as Button);
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void button_Scenario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectScenarioForm());
        }

        public void button_Data_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataForm());
        }


        public void button_Configuration_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataForm());
        }

        public void button_Learning_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateMiddleLayersForm());
        }
    }
}
