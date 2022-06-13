using System;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class LearningForm : Form
    {
        public LearningForm()
        {
            InitializeComponent();
            comboBox_SelectCostFunction.DataSource = Enum.GetValues(typeof(NeuralNetwork.CostFunctionEnum));
            comboBox_SelectCostFunction.SelectedIndex = 1;
            numericUpDown_TestPercent_ValueChanged(null, null);
            comboBox_SelectCostFunction_SelectionChangeCommitted(null, null);
        }

        private void UpdateDataGrids()
        {
            var learningData = GlobalTemplate.LearningData;
            var dataset = learningData.ConvertToDotNetDataSet();

            dataGridView_Learning.DataSource = dataset.Tables[0];
            label_Learning.Text = "Обучающая выборка";
            label_Learning.Text += $" Всего {learningData.ParamNamesInput.Count + learningData.ParamNamesOutput.Count} параметров";
            label_Learning.Text += $" и {learningData.LearningExamples.Count} пример(ов)";

            dataGridView_Test.DataSource = dataset.Tables[1];
            label_Test.Text = "Тестовая выборка";
            label_Test.Text += $" Всего {learningData.ParamNamesInput.Count + learningData.ParamNamesOutput.Count} параметров";
            label_Test.Text += $" и {learningData.TestExamples.Count} пример(ов)";
        }

        private void comboBox_SelectCostFunction_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var costFunction = (NeuralNetwork.CostFunctionEnum)comboBox_SelectCostFunction.SelectedValue;
            GlobalTemplate.NeuralNetwork.SetCostFunction(costFunction);
        }

        private void numericUpDown_ErrorLimit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_EpochCount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_LearningRate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown_TestPercent_ValueChanged(object sender, EventArgs e)
        {
            var percent = (int)numericUpDown_TestPercent.Value;
            GlobalTemplate.LearningData.SplitOnLearningAndTestData(percent);
            UpdateDataGrids();
        }

        private void button_StartLearning_Click(object sender, EventArgs e)
        {
            var learningData = GlobalTemplate.LearningData;
            var neuralNetwork = GlobalTemplate.NeuralNetwork;
            var learningRate = (double)numericUpDown_LearningRate.Value;
            if (radioButton_ErrorLimit.Checked == true)
            {
                var errorLimit = (double)numericUpDown_ErrorLimit.Value;
                neuralNetwork.Learn_Backpropogation(learningData, errorLimit, learningRate);
            }
            else if (radioButton_EpochCount.Checked == true)
            {
                var epochTimes = (int)numericUpDown_EpochCount.Value;
                neuralNetwork.Learn_Backpropogation(learningData, epochTimes, learningRate);
            }
        }

        private void button_Replace_Click(object sender, EventArgs e)
        {
            //TODO: сделать перекидывание примеров
        }
    }
}
