using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Constructor
{
    public partial class ScenarioControl : UserControl
    {
        public Image ScenarioImage
        {
            get { return pictureBox_Image.Image; }
            set { pictureBox_Image.Image = value; }
        }

        public string ScenarioName
        {
            get { return label_ScenarioName.Text; }
            set { label_ScenarioName.Text = value; }
        }

        public string ScenarioDescription
        {
            get { return label_ScenarioDescription.Text; }
            set { label_ScenarioDescription.Text = value; }
        }

        public ScenarioControl()
        {
            InitializeComponent();

            var ListControls = new List<Control>() { this, panel_Main, pictureBox_Image, label_ScenarioName, label_ScenarioDescription };
            ListControls.ForEach(item =>
            {
                item.MouseEnter += (object sender, EventArgs e) =>
                {
                    BackColor = Color.White;
                };
                item.MouseLeave += (object sender, EventArgs e) =>
                {
                    BackColor = Color.FromArgb(77, 77, 77);
                };
            });
            ListControls.Skip(1).ToList().ForEach(item => item.DoubleClick += CustomDoubleClick);
        }

        public void CustomDoubleClick(object sender, EventArgs e)
        {
            this.OnDoubleClick(new EventArgs());
        }
    }
}
