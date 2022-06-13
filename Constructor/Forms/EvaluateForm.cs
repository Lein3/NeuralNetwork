using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class EvaluateForm : Form
    {
        public EvaluateForm()
        {
            InitializeComponent();

            var learningData = GlobalTemplate.LearningData;
            var dataset = learningData.ConvertToDotNetDataSet();           

            AddPredictedAnswer(dataset.Tables[0]);
            AddPredictedAnswer(dataset.Tables[1]);
            dataGridView_Learning.DataSource = dataset.Tables[0];
            dataGridView_Test.DataSource = dataset.Tables[1];
            dataGridView_Learning.Columns[dataGridView_Learning.Columns.Count - 1].DisplayIndex = 0;
            dataGridView_Learning.Columns[dataGridView_Learning.Columns.Count - 2].DisplayIndex = 0;
            dataGridView_Test.Columns[dataGridView_Learning.Columns.Count - 1].DisplayIndex = 0;
            dataGridView_Test.Columns[dataGridView_Learning.Columns.Count - 2].DisplayIndex = 0;
        }

        private void AddPredictedAnswer(DataTable dataTable)
        {
            DataColumn dataColumn = new DataColumn("Ответ сети", typeof(double));
            dataTable.Columns.Add(dataColumn);

            var lastIndexOfArray = dataTable.Rows[0].ItemArray.Length - 1;
            foreach(DataRow row in dataTable.Rows)
            {
                var inputSignals = row.ItemArray.Take(lastIndexOfArray - 1).Select(item => Convert.ToDouble(item)).ToList(); //еще раз минус один потому что там ответ который не должен попадать
                var answer = GlobalTemplate.NeuralNetwork.Predict_ReturnOnlyValues(inputSignals)[0];
                row["Ответ сети"] = Math.Round(answer, 4);
            }
        }

        private void dataGridView_Learning_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView_Learning.Rows)
            {
                
                var expectedAnswer = Convert.ToDouble(row.Cells[dataGridView_Learning.Columns.Count - 1].Value);
                var actualAnswer = Convert.ToDouble(row.Cells[dataGridView_Learning.Columns.Count - 2].Value);
                if (Math.Abs(expectedAnswer - actualAnswer) > 0.2)
                {
                    row.Cells[dataGridView_Learning.Columns.Count - 1].Style.BackColor = Color.IndianRed;
                    row.Cells[dataGridView_Learning.Columns.Count - 2].Style.BackColor = Color.IndianRed;
                    count++;
                }
            }
            label_Learning.Text = "Обучающая выборка " + count.ToString();
        }

        private void dataGridView_Test_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView_Test.Rows)
            {
                
                var expectedAnswer = Convert.ToDouble(row.Cells[dataGridView_Test.Columns.Count - 1].Value);
                var actualAnswer = Convert.ToDouble(row.Cells[dataGridView_Test.Columns.Count - 2].Value);
                if (Math.Abs(expectedAnswer - actualAnswer) > 0.2)
                {
                    row.Cells[dataGridView_Test.Columns.Count - 1].Style.BackColor = Color.IndianRed;
                    row.Cells[dataGridView_Test.Columns.Count - 2].Style.BackColor = Color.IndianRed;
                    count++;
                }
            }
            label_Test.Text = "Тестовая выборка " + count.ToString();
        }
    }
}
