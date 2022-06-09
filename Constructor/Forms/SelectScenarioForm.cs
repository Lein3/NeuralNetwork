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
    public partial class SelectScenarioForm : Form
    {
        public SelectScenarioForm()
        {
            InitializeComponent();
        }

        private void scenarioControl1_DoubleClick(object sender, EventArgs e)
        {
            //TODO: выбор сценария
            var parent = this.ParentForm as MainForm;
            parent.button_Data.Enabled = true;
            parent.button_Data_Click(sender, e);
        }

        private void scenarioControl2_DoubleClick(object sender, EventArgs e)
        {
            //TODO: выбор сценария
            var parent = this.ParentForm as MainForm;
            parent.button_Data.Enabled = true;
            parent.button_Data_Click(sender, e);
        }
    }
}
