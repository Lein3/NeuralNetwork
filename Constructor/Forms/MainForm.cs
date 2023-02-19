using System;
using System.Windows.Forms;
using System.Linq;
using Constructor.Properties;
using System.Drawing;
using Newtonsoft.Json;
using NeuralNetworkNamespace;
using System.IO;

namespace Constructor
{
    public partial class MainForm : Form
    {
        public Form PreviousForm { get; set; }
        private Form OpenedForm { get; set; }
        public MainForm()
        {
            InitializeComponent();
            this.Icon = Resources.mainIcon;
            foreach (Button button in panel_Left.Controls.OfType<Button>())
            {
                button.Click += Recolor_Click;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (OpenedForm != null)
            {
                if (OpenedForm.Name == childForm.Name)
                {
                    return;
                }
                OpenedForm.Dispose();
            }

            OpenedForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Screen.Controls.Clear();
            panel_Screen.Controls.Add(childForm);
            panel_Screen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void RecolorButtons(Button currentButton)
        {
            foreach (Button button in panel_Left.Controls.OfType<Button>())
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

        public void button_MainScreen_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Close();
        }

        public void button_Scenario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SelectScenarioForm());
            panel_Configuration.Visible = false;
        }

        public void button_Data_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DataForm());
            panel_Configuration.Visible = false;
        }

        public void button_Data_Click(int datasetId)
        {
            OpenChildForm(new DataForm(datasetId));
            panel_Configuration.Visible = false;
        }

        public void button_Configuration_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NetworkConfigurationForm(this));
            panel_Configuration.Visible = !panel_Configuration.Visible;
        }

        public void button_LayersReady_Click(object sender, EventArgs e)
        {
            (OpenedForm as NetworkConfigurationForm).SaveNetwork();
            OpenChildForm(new LearningForm());
            button_Learning.Enabled = true;
            panel_Configuration.Visible = false;
            RecolorButtons(button_Learning);
        }

        public void button_Learning_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LearningForm());
        }

        public void button_Evaluate_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EvaluateForm());
        }

        private void button_SaveModel_Click(object sender, EventArgs e)
        {
            if (panel_SaveModel.Visible == false)
            {
                panel_SaveModel.Visible = true;
                textBox_ModelName.Text = GlobalTemplate.ModelName;
                return;
            }

            var folderFileDialog = new FolderBrowserDialog();
            folderFileDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (folderFileDialog.ShowDialog() == DialogResult.OK)
            {             
                string json = JsonConvert.SerializeObject(GlobalTemplate.NeuralNetwork, Formatting.Indented, AuthorizationForm.Settings);
                string path = $"{folderFileDialog.SelectedPath}\\{GlobalTemplate.ModelName}.nc";
                using (StreamWriter file = new StreamWriter(path, false))
                {
                    file.WriteLine(json);
                    file.Close();
                }
                var neural = JsonConvert.DeserializeObject<NeuralNetwork>(json, AuthorizationForm.Settings);
            }
        }

        private void textBox_ModelName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_ModelName.Text))
            {
                GlobalTemplate.ModelName = textBox_ModelName.Text;
            }
            else
            {
                GlobalTemplate.ModelName = "Моя модель";
            }
        }
    }
}
