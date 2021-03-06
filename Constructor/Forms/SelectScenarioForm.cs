using System;
using System.Windows.Forms;

namespace Constructor
{
    public partial class SelectScenarioForm : Form
    {
        public SelectScenarioForm()
        {
            InitializeComponent();
        }

        private void scenarioControl1_DoubleClick(object sender, EventArgs e)
        {
            GlobalTemplate.CurrentScenario = GlobalTemplate.Scenario.binaryClassification;
            var parent = this.ParentForm as MainForm;
            parent.button_Data.Enabled = true;
            parent.RecolorButtons(parent.button_Data);
            parent.button_Data_Click(sender, e);
        }

        private void scenarioControl2_DoubleClick(object sender, EventArgs e)
        {
            GlobalTemplate.CurrentScenario = GlobalTemplate.Scenario.multiclassClassification;
            var parent = this.ParentForm as MainForm;
            parent.button_Data.Enabled = true;
            parent.RecolorButtons(parent.button_Data);
            parent.button_Data_Click(sender, e);
        }

        private void scenarioControl4_DoubleClick(object sender, EventArgs e)
        {
            GlobalTemplate.CurrentScenario = GlobalTemplate.Scenario.multimarkClassification;
            var parent = this.ParentForm as MainForm;
            parent.button_Data.Enabled = true;
            parent.RecolorButtons(parent.button_Data);
            parent.button_Data_Click(sender, e);
        }
    }
}
