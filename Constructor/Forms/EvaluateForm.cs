using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            FillPanelForPredict(learningData);

            var stringBuilder = new StringBuilder();
            foreach(var pair in GlobalTemplate.LearningData.ClassesCount)
            {
                stringBuilder.AppendLine($"{pair.Key} - {pair.Value}");
            }
            label_datasetInfo.Text += stringBuilder.ToString();
        }

        private void FillPanelForPredict(LearningData learningData)
        {
            int startX = 10;
            int startY = 10;
            foreach (var paramName in learningData.ParamNamesInput)
            {
                var label = new Label();
                label.AutoSize = true;
                label.Font = new Font("Microsoft JhengHei", 11.25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                label.ForeColor = Color.White;
                label.Location = new Point(startX, startY);
                label.Size = new Size(385, 19);
                label.Text = paramName;
                panel_Predict.Controls.Add(label);

                var textBox = new TextBox();
                textBox.BackColor = Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.Font = new Font("Microsoft JhengHei", 8.25F);
                textBox.ForeColor = Color.White;
                textBox.Location = new Point(startX, startY + 25);
                textBox.Size = new Size(240, 22);
                panel_Predict.Controls.Add(textBox);

                startY += 60;
            }

            var labelPredict = new Label();
            labelPredict.AutoSize = true;
            labelPredict.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelPredict.ForeColor = System.Drawing.Color.White;
            labelPredict.Location = new System.Drawing.Point(startX + 40, startY + 20);
            labelPredict.Size = new System.Drawing.Size(120, 30);
            labelPredict.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            panel_Predict.Controls.Add(labelPredict);

            var buttonPredict = new Button();
            buttonPredict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            buttonPredict.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonPredict.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(35)))));
            buttonPredict.FlatAppearance.BorderSize = 0;
            buttonPredict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonPredict.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonPredict.ForeColor = System.Drawing.Color.White;
            buttonPredict.Location = new System.Drawing.Point(startX, startY + 60);
            buttonPredict.Size = new System.Drawing.Size(120, 50);
            buttonPredict.Text = "Предсказать";
            buttonPredict.UseVisualStyleBackColor = false;
            buttonPredict.Click += button_Predict_Click;
            panel_Predict.Controls.Add(buttonPredict);

            var buttonGenerateRandom = new Button();
            buttonGenerateRandom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            buttonGenerateRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonGenerateRandom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(35)))));
            buttonGenerateRandom.FlatAppearance.BorderSize = 0;
            buttonGenerateRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            buttonGenerateRandom.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            buttonGenerateRandom.ForeColor = System.Drawing.Color.White;
            buttonGenerateRandom.Location = new System.Drawing.Point(startX + 140, startY + 60);
            buttonGenerateRandom.Size = new System.Drawing.Size(120, 50);
            buttonGenerateRandom.Text = "Сгенерировать пример";
            buttonGenerateRandom.UseVisualStyleBackColor = false;
            buttonGenerateRandom.Click += button_Generate_Click;
            panel_Predict.Controls.Add(buttonGenerateRandom);
        }

        private void button_Predict_Click(object sender, EventArgs e)
        {
            var values = new List<double>();
            foreach (var textbox in panel_Predict.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    MessageBox.Show("Не все поля заполнены");
                    return;
                }
                values.Add(Convert.ToDouble(textbox.Text));
            }

            var answer = GlobalTemplate.NeuralNetwork.Predict_ReturnOnlyValues(values);
            for (int i = 0; i < answer.Count; i++)
            {
                answer[i] = Math.Round(answer[i], 4);
            }

            var stringAnswer = String.Join(", ", answer);
            panel_Predict.Controls.OfType<Label>().Last().Text = $"[{stringAnswer}]";
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {           
            var values = new List<double>();
            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < dataGridView_Learning.ColumnCount - GlobalTemplate.LearningData.ClassNames.Count * 2; i++)
            {
                var randomRow = random.Next(0, dataGridView_Learning.RowCount);
                var value = Convert.ToDouble(dataGridView_Learning.Rows[randomRow].Cells[i].Value);
                panel_Predict.Controls.OfType<TextBox>().ToList()[i].Text = value.ToString();
                values.Add(value);
            }

            var answer = GlobalTemplate.NeuralNetwork.Predict_ReturnOnlyValues(values);
            for (int i = 0; i < answer.Count; i++)
            {
                answer[i] = Math.Round(answer[i], 4);
            }

            var stringAnswer = String.Join(", ", answer);
            panel_Predict.Controls.OfType<Label>().Last().Text = $"[{stringAnswer}]";
        }

        private void AddPredictedAnswer(DataTable dataTable)
        {
            foreach (var className in GlobalTemplate.LearningData.ClassNames)
            {
                DataColumn dataColumn = new DataColumn(className, typeof(double));
                dataTable.Columns.Add(dataColumn);
            }

            var lastIndexOfArray = dataTable.Rows[0].ItemArray.Length - GlobalTemplate.LearningData.ClassNames.Count;
            foreach(DataRow row in dataTable.Rows)
            {
                var inputSignals = row.ItemArray.Take(lastIndexOfArray - GlobalTemplate.LearningData.ClassNames.Count).Select(item => Convert.ToDouble(item)).ToList(); //еще раз минус один потому что там ответ который не должен попадать
                var answer = GlobalTemplate.NeuralNetwork.Predict_ReturnOnlyValues(inputSignals);

                for (int i = 0; i < GlobalTemplate.LearningData.ClassNames.Count; i++)
                {
                    row[GlobalTemplate.LearningData.ClassNames[i]] = Math.Round(answer[i], 4);
                }
            }
        }

        private void dataGridView_Learning_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            label_Learning.Text = String.Empty;
            int criticalCount = 0;
            if (GlobalTemplate.CurrentScenario == GlobalTemplate.Scenario.binaryClassification)
            {
                foreach (DataGridViewRow row in dataGridView_Learning.Rows)
                {

                    var expectedAnswer = Convert.ToDouble(row.Cells[dataGridView_Learning.Columns.Count - 1].Value);
                    var actualAnswer = Convert.ToDouble(row.Cells[dataGridView_Learning.Columns.Count - 2].Value);
                    if (Math.Abs(expectedAnswer - actualAnswer) > 0.2)
                    {
                        row.Cells[dataGridView_Learning.Columns.Count - 1].Style.BackColor = Color.IndianRed;
                        row.Cells[dataGridView_Learning.Columns.Count - 2].Style.BackColor = Color.IndianRed;
                        criticalCount++;
                    }
                }
                label_Learning.Text = "Тестовая выборка количество критических примеров " + criticalCount.ToString() + " \n";
            }

            var dictionary = new Dictionary<string, int>();
            for (int i = 0; i < GlobalTemplate.LearningData.ClassNames.Count; i++)
            {
                var expected = 0;
                var actual = 0;
                foreach (DataGridViewRow row in dataGridView_Learning.Rows)
                {
                    var expectedAnswer = Convert.ToDouble(row.Cells[dataGridView_Learning.Columns.Count - GlobalTemplate.LearningData.ClassNames.Count * 2 + i].Value);
                    var actualAnswer = Convert.ToDouble(row.Cells[dataGridView_Learning.Columns.Count - GlobalTemplate.LearningData.ClassNames.Count + i].Value);

                    if (expectedAnswer >= 0.6)
                        expected++;
                    if (actualAnswer >= 0.6)
                        actual++;
                }
                dictionary.Add($"в наборе данных было {GlobalTemplate.LearningData.ClassNames[i]}", expected);
                dictionary.Add($"нейросеть ответила {GlobalTemplate.LearningData.ClassNames[i]}", actual);
            }

            foreach (var pair in dictionary)
            {
                label_Learning.Text += $"   {pair.Key} - {pair.Value}   ";
                label_Learning.Text += "|";
            }
        }

        private void dataGridView_Test_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            label_Test.Text = String.Empty;
            int criticalCount = 0;
            if (GlobalTemplate.CurrentScenario == GlobalTemplate.Scenario.binaryClassification)
            {
                foreach (DataGridViewRow row in dataGridView_Test.Rows)
                {

                    var expectedAnswer = Convert.ToDouble(row.Cells[dataGridView_Test.Columns.Count - 1].Value);
                    var actualAnswer = Convert.ToDouble(row.Cells[dataGridView_Test.Columns.Count - 2].Value);
                    if (Math.Abs(expectedAnswer - actualAnswer) > 0.2)
                    {
                        row.Cells[dataGridView_Test.Columns.Count - 1].Style.BackColor = Color.IndianRed;
                        row.Cells[dataGridView_Test.Columns.Count - 2].Style.BackColor = Color.IndianRed;
                        criticalCount++;
                    }
                }
                label_Test.Text = "Тестовая выборка количество критических примеров " + criticalCount.ToString() + " \n";
            }           

            var dictionary = new Dictionary<string, int>();
            for (int i = 0; i < GlobalTemplate.LearningData.ClassNames.Count; i++)
            {
                var expected = 0;
                var actual = 0;
                foreach (DataGridViewRow row in dataGridView_Test.Rows)
                {
                    var expectedAnswer = Convert.ToDouble(row.Cells[dataGridView_Test.Columns.Count - GlobalTemplate.LearningData.ClassNames.Count * 2 + i].Value);
                    var actualAnswer = Convert.ToDouble(row.Cells[dataGridView_Test.Columns.Count - GlobalTemplate.LearningData.ClassNames.Count + i].Value);

                    if (expectedAnswer >= 0.6)
                        expected++;
                    if (actualAnswer >= 0.6)
                        actual++;
                }
                dictionary.Add($"в наборе данных было {GlobalTemplate.LearningData.ClassNames[i]}", expected);
                dictionary.Add($"нейросеть ответила {GlobalTemplate.LearningData.ClassNames[i]}", actual);
            }
            
            foreach (var pair in dictionary)
            {
                label_Test.Text += $"   {pair.Key} - {pair.Value}   ";
                label_Test.Text += "|";
            }
        }
    }
}
