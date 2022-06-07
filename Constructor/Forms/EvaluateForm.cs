using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Constructor
{
    public partial class EvaluateForm : Form
    {
        public EvaluateForm()
        {
            InitializeComponent();
            LoadDataset();
        }

        private void LoadDataset()
        {
            //var listLearning = new List<CurrentExample>();
            //foreach (var example in NetworkTemplate.LearningData.LearningExamples)
            //{
            //    var answer = NetworkTemplate.NeuralNetwork.Predict_ReturnOnlyValues(example.InputSignals);
            //    var answerCurrent = Math.Round(answer[0], 4);
            //    listLearning.Add(new CurrentExample(example, answerCurrent));
            //}
            //dataGridView_learning.DataSource = listLearning;
            //label_learningError.Text += " " + CalculateError(dataGridView_learning).ToString() + "%";

            //var listTest = new List<CurrentExample>();
            //foreach (var example in NetworkTemplate.LearningData.TestExamples)
            //{
            //    var answer = NetworkTemplate.NeuralNetwork.Predict_ReturnOnlyValues(example.InputSignals);
            //    var answerCurrent = Math.Round(answer[0], 4);
            //    listTest.Add(new CurrentExample(example, answerCurrent));
            //}
            //dataGridView_test.DataSource = listTest;
            //label_testError.Text += " " + CalculateError(dataGridView_test).ToString() + "%";
            //CalculateCritCount();
        }

        private double CalculateError(DataGridView dataGridView)
        {
            var listErrors = new List<double>();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                var error = (double)row.Cells[13].Value - (double)row.Cells[14].Value;
                error = Math.Abs(error);
                listErrors.Add(error);
            }
            return Math.Round(listErrors.Average() * 100, 2);

        }

        private void CalculateCritCount()
        {
            int count = 0;
            foreach (DataGridViewRow row in dataGridView_test.Rows)
            {
                var expected = (double)row.Cells[13].Value;
                var actual = (double)row.Cells[14].Value;
                var error = Math.Abs(expected - actual);
                if (error >= 0.5)
                {
                    row.Cells[13].Style.BackColor = Color.Red;
                    row.Cells[14].Style.BackColor = Color.Red;
                    row.Cells[13].Style.ForeColor = Color.White;
                    row.Cells[14].Style.ForeColor = Color.White;
                    count++;
                }
            }
            label_criticalCount.Text += count.ToString();
        }

        private void dataGridView_test_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_test.Rows)
            {
                var expected = (double)row.Cells[13].Value;
                var actual = (double)row.Cells[14].Value;
                var error = Math.Abs(expected - actual);
                if (error >= 0.5)
                {
                    row.Cells[13].Style.BackColor = Color.Red;
                    row.Cells[14].Style.BackColor = Color.Red;
                    row.Cells[13].Style.ForeColor = Color.White;
                    row.Cells[14].Style.ForeColor = Color.White;
                }
            }
        }
    }
}
