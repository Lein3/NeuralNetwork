using System;
using System.Data;
using System.Drawing;
using System.Linq;
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
                parent.dataGridView.DataSource = null;
                parent.dataGridView.DataSource = parent.learningData.ConvertToDotNetDataSet().Tables[0];
                parent.FirstUpdateComboBoxPredictMark();
            }
            else
            {
                parent.learningData.ParamNamesOutput.Add(null);
                parent.learningData.MoveToParamOutput(comboBox_PredictMark.SelectedIndex);
                button_AddMark.Enabled = true;
                parent.dataGridView.DataSource = null;
                parent.dataGridView.DataSource = parent.learningData.ConvertToDotNetDataSet().Tables[0];
                parent.UpdateAllComboBoxPredictMark();
            }
            textBox_PredictMarkName.Text = "Класс " + comboBox_PredictMark.GetItemText(comboBox_PredictMark.SelectedItem);
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
            predictMarkControl.comboBox_PredictMark_SelectionChangeCommitted(null, null); //вот отсюда его не трогай формочки будут мозги ебать
        }

        private void button_RemoveMark_Click(object sender, EventArgs e)
        {
            if (MarkIndex == 0)
            {
                return;
            }

            var parent = ParentForm as DataForm;
            parent.Controls.Remove(this);
            parent.learningData.MoveToParamInput(MarkIndex);
            parent.learningData.ClassNames.Remove(parent.learningData.ClassNames.Last());
            parent.dataGridView.DataSource = null;
            parent.dataGridView.DataSource = parent.learningData.ConvertToDotNetDataSet().Tables[0];
            parent.UpdateAllComboBoxPredictMark();
        }

        private void PredictMarkControl_Load(object sender, EventArgs e)
        {
            var parent = ParentForm as DataForm;
            comboBox_PredictMark.DataSource = parent?.learningData?.ParamNamesInput.Concat(parent.learningData.ParamNamesOutput).ToList();
            comboBox_PredictMark.SelectedIndex = comboBox_PredictMark.Items.Count - 1 - MarkIndex;         
        }

        private void textBox_PredictMarkName_TextChanged(object sender, EventArgs e)
        {
            var parent = ParentForm as DataForm;
            if (parent.learningData.ClassNames.Count <= MarkIndex)
            {
                for (int i = parent.learningData.ClassNames.Count; i < MarkIndex + 1; i++)
                {
                    parent.learningData.ClassNames.Add("");
                }               
            }
            parent.learningData.ClassNames[MarkIndex] = textBox_PredictMarkName.Text;
            parent.UpdateAllComboBoxPredictMark();
        }
    }
}
