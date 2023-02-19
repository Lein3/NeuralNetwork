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
                parent.LearningData.SwapToParamOutput(comboBox_PredictMark.SelectedIndex);
                parent.dataGridView.DataSource = null;
                parent.dataGridView.DataSource = parent.LearningData.ConvertToDotNetDataSet().Tables[0];
                parent.FirstUpdateComboBoxPredictMark();
            }
            else
            {
                parent.LearningData.ParamNamesOutput.Add(null);
                parent.LearningData.MoveToParamOutput(comboBox_PredictMark.SelectedIndex);
                button_AddMark.Enabled = true;
                parent.dataGridView.DataSource = null;
                parent.dataGridView.DataSource = parent.LearningData.ConvertToDotNetDataSet().Tables[0];
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
            parent.LearningData.MoveToParamInput(MarkIndex);
            parent.LearningData.ClassNames.Remove(parent.LearningData.ClassNames.Last());
            parent.dataGridView.DataSource = null;
            parent.dataGridView.DataSource = parent.LearningData.ConvertToDotNetDataSet().Tables[0];
            parent.UpdateAllComboBoxPredictMark();
        }

        private void PredictMarkControl_Load(object sender, EventArgs e)
        {
            var parent = ParentForm as DataForm;
            comboBox_PredictMark.DataSource = parent?.LearningData?.ParamNamesInput.Concat(parent.LearningData.ParamNamesOutput).ToList();
            comboBox_PredictMark.SelectedIndex = comboBox_PredictMark.Items.Count - 1 - MarkIndex;         
        }

        private void textBox_PredictMarkName_TextChanged(object sender, EventArgs e)
        {
            var parent = ParentForm as DataForm;
            if (parent.LearningData.ClassNames.Count <= MarkIndex)
            {
                for (int i = parent.LearningData.ClassNames.Count; i < MarkIndex + 1; i++)
                {
                    parent.LearningData.ClassNames.Add("");
                }               
            }
            parent.LearningData.ClassNames[MarkIndex] = textBox_PredictMarkName.Text;
            parent.UpdateAllComboBoxPredictMark();
        }
    }
}
