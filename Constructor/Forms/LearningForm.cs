using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class LearningForm : Form
    {
        private enum DataGrid { learning, test };
        private DataGrid currentDataGridView;
        public LearningForm()
        {
            InitializeComponent();
            if (GlobalTemplate.LearningData == null)
            {
                MessageBox.Show("Отсутствует набор данных для обучения");
                return;
            }

            comboBox_SelectCostFunction.DataSource = Enum.GetValues(typeof(NeuralNetwork.CostFunctionEnum));
            if (GlobalTemplate.CurrentScenario == GlobalTemplate.Scenario.multiclassClassification)
            {
                comboBox_SelectCostFunction.SelectedIndex = 2;
            }
            else
            {
                comboBox_SelectCostFunction.SelectedIndex = 1;
            }

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

            var name = comboBox_SelectCostFunction.GetItemText(comboBox_SelectCostFunction.SelectedItem);
            var id = Connection.db.Value.CostFunctions.Where(item => item.Name == name).FirstOrDefault().ID;
            GlobalTemplate.DatabaseNeuralNetwork.CostFunction = id;
            Connection.db.Value.SaveChanges();
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

        private async void button_StartLearning_Click(object sender, EventArgs e)
        {
            var learningData = GlobalTemplate.LearningData;
            var neuralNetwork = GlobalTemplate.NeuralNetwork;
            var learningRate = (double)numericUpDown_LearningRate.Value;
            if (radioButton_ErrorLimit.Checked == true)
            {
                var errorLimit = (double)numericUpDown_ErrorLimit.Value / 100;
                neuralNetwork.SetCostFunction(NeuralNetwork.CostFunctionEnum.BinaryLogLoss);
                int currentEpoch = 0;
                label_Statistcs.Text = String.Empty;
                do
                {
                    currentEpoch++;
                    neuralNetwork.Learn_Backpropogation(learningData, 1, learningRate);
                    if (currentEpoch % 250 == 0)
                    {
                        string result = await Task.Run(() => $"Текущая эпоха {currentEpoch} средняя ошибка " + neuralNetwork.LearningStatistics.currentStatics.Last().ToString() + "\n");
                        await Task.Run(() => label_Statistcs.Text += result);
                    }
                    if (currentEpoch % 1000 == 0)
                    {
                        await Task.Run(() => label_Statistcs.Text = String.Empty);
                        string result = await Task.Run(() => $"Текущая эпоха {currentEpoch} средняя ошибка " + neuralNetwork.LearningStatistics.currentStatics.Last().ToString() + "\n");
                        await Task.Run(() => label_Statistcs.Text += result);
                    }
                } while (neuralNetwork.LearningStatistics.currentStatics.Last() >= errorLimit);
            }
            else if (radioButton_EpochCount.Checked == true)
            {
                var epochTimes = (int)numericUpDown_EpochCount.Value;
                neuralNetwork.SetCostFunction(NeuralNetwork.CostFunctionEnum.BinaryLogLoss);
                label_Statistcs.Text = String.Empty;
                for (int i = 0; i < epochTimes; i++)
                {
                    neuralNetwork.Learn_Backpropogation(learningData, 1, learningRate);
                    if (i % 250 == 0)
                    {
                        string result = await Task.Run(() => $"Обучили {i} из {epochTimes} средняя ошибка " + neuralNetwork.LearningStatistics.currentStatics.Last().ToString() + "\n");
                        await Task.Run(() => label_Statistcs.Text += result);
                    }
                    if (i % 1000 == 0)
                    {
                        await Task.Run(() => label_Statistcs.Text = String.Empty);
                        string result = await Task.Run(() => $"Обучили {i} из {epochTimes} средняя ошибка " + neuralNetwork.LearningStatistics.currentStatics.Last().ToString() + "\n");
                        await Task.Run(() => label_Statistcs.Text += result);
                    }
                }
            }

            var parent = this.ParentForm as MainForm;
            parent.button_Evaluate.Enabled = true;
            parent.button_SaveModel.Enabled = true;
            parent.RecolorButtons(parent.button_Evaluate);
            parent.button_Evaluate_Click(sender, e);

            SaveLearningResults();
        }

        private void SaveLearningResults()
        {
            if (GlobalTemplate.CurrentUser != null)
            {
                var learningResults = new LearningResults();

                if (radioButton_EpochCount.Checked == true)
                    learningResults.EpochCount = (int)numericUpDown_EpochCount.Value;
                if (radioButton_ErrorLimit.Checked == true)
                    learningResults.ErrorLimit = (double)numericUpDown_ErrorLimit.Value / 100;

                learningResults.LearningRate = (double)numericUpDown_LearningRate.Value;
                learningResults.ExamplesLearningCount = GlobalTemplate.LearningData.LearningExamples.Count;
                learningResults.ExamplesTestCount = GlobalTemplate.LearningData.TestExamples.Count;
                learningResults.ResultErrorLearningExamples = 0;

                Connection.db.Value.LearningResults.Add(learningResults);
                Connection.db.Value.SaveChanges();

                var kek = new NeuralNetworks_LearningResults()
                {
                    ID_NeuralNetwork = GlobalTemplate.DatabaseNeuralNetwork.ID,
                    ID_LearningResults = learningResults.ID
                };
                Connection.db.Value.NeuralNetworks_LearningResults.Add(kek);
                Connection.db.Value.SaveChanges();
            }
        }

        private void button_Replace_Click(object sender, EventArgs e)
        {          
            var learningData = GlobalTemplate.LearningData;
            switch (currentDataGridView)
            {
                case DataGrid.learning:
                    var index = dataGridView_Learning.CurrentCell.RowIndex;
                    learningData.TestExamples.Add(learningData.LearningExamples[index]);
                    learningData.LearningExamples.RemoveAt(index);
                    UpdateDataGrids();
                    break;
                case DataGrid.test:
                    var index2 = dataGridView_Test.CurrentCell.RowIndex;
                    learningData.LearningExamples.Add(learningData.TestExamples[index2]);
                    learningData.TestExamples.RemoveAt(index2);
                    UpdateDataGrids();
                    break;
                default:
                    return;
            }
        }

        private void dataGridView_Learning_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Test.ClearSelection();
            currentDataGridView = DataGrid.learning;
        }

        private void dataGridView_Test_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_Learning.ClearSelection();
            currentDataGridView = DataGrid.test;
        }
    }
}
