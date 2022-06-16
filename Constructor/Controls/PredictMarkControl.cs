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
    public partial class PredictMarkControl : UserControl
    {
        public int MarkIndex { get; set; }
        public PredictMarkControl()
        {
            InitializeComponent();
        }

        private void comboBox_PredictMark_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var parent = ParentForm as DataForm;
            if (GlobalTemplate.CurrentScenario == GlobalTemplate.Scenario.binaryClassification || MarkIndex == 0)
            {
                parent.learningData.SwapToParamOutput(comboBox_PredictMark.SelectedIndex);
            }
            else
            {
                parent.learningData.ParamNamesOutput.Add(null);
                parent.learningData.MoveToParamOutput(comboBox_PredictMark.SelectedIndex);
            }
            parent.dataGridView.DataSource = null;
            parent.dataGridView.DataSource = parent.learningData.ConvertToDotNetDataSet().Tables[0];
            parent.UpdateComboBoxPredictMark();
        }

        private void button_AddMark_Click(object sender, EventArgs e)
        {
            var parent = ParentForm as DataForm;
            var lastpredictMarkControl = parent.Controls.OfType<PredictMarkControl>().OrderBy(item => item.MarkIndex).Last();
            var lastIndex = lastpredictMarkControl.MarkIndex + 1;
            var lastLocationX = lastpredictMarkControl.Location.X + 300;
            var lastLocationY = lastpredictMarkControl.Location.Y;
            var predictMarkControl = new PredictMarkControl() { MarkIndex = lastIndex, Location = new Point(lastLocationX, lastLocationY) };
            parent.Controls.Add(predictMarkControl);
            parent.UpdateComboBoxPredictMark();
        }

        private void button_RemoveMark_Click(object sender, EventArgs e)
        {
            if (MarkIndex == 0)
            {
                return;
            }

            var parent = ParentForm as DataForm;
            parent.Controls.Remove(this);
            parent.UpdateComboBoxPredictMark();
        }
    }
}
