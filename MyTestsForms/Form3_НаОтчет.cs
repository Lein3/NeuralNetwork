using NeuralNetworkLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestsForms
{
    public partial class Form3_НаОтчет : Form
    {
        Structure structure1 = new Structure(4, 1, 6);
        NeuralNetwork neuralNetwork;
        List<double> outputs = new List<double>();
        List<double[]> inputs = new List<double[]>();
        List<TempClassForOtchet> aa;
        public Form3_НаОтчет()
        {           
            InitializeComponent();
            Console.WriteLine("ждем");
            neuralNetwork = new NeuralNetwork(structure1);

            //(a+b)*c+d
            inputs.Add(new double[] { 0, 0, 0, 0 });
            inputs.Add(new double[] { 0, 0, 0, 1 });
            inputs.Add(new double[] { 0, 0, 1, 0 });
            inputs.Add(new double[] { 0, 0, 1, 1 });

            inputs.Add(new double[] { 0, 1, 0, 0 });
            inputs.Add(new double[] { 0, 1, 0, 1 });
            inputs.Add(new double[] { 0, 1, 1, 0 });
            inputs.Add(new double[] { 0, 1, 1, 1 });

            inputs.Add(new double[] { 1, 0, 0, 0 });
            inputs.Add(new double[] { 1, 0, 0, 1 });
            inputs.Add(new double[] { 1, 0, 1, 0 });
            inputs.Add(new double[] { 1, 0, 1, 1 });

            inputs.Add(new double[] { 1, 1, 0, 0 });
            inputs.Add(new double[] { 1, 1, 0, 1 });
            inputs.Add(new double[] { 1, 1, 1, 0 });
            inputs.Add(new double[] { 1, 1, 1, 1 });

            outputs = new List<double>() { 0, 1, 0, 1,       0, 1, 1, 1,      0, 1, 1, 1,        0, 1, 1, 1 };           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(580, 780);
            var list = new List<TempClassForOtchet>();
            for (int i = 0; i < inputs.Count; i++)
                list.Add(new TempClassForOtchet(inputs[i], outputs[i]));
            dataGridView1.DataSource = list;
            dataGridView1.Columns[2].Visible = false;
        }

        private async void button19_Click(object sender, EventArgs e)
        {
            var value = Convert.ToInt32(textBox2.Text);
            var clonedOutputs = new List<double>(outputs);
            var clonedInputs = new List<double[]>(inputs);
            var listForAnswers = new List<double[]>();
            var listForAnswers2 = new List<double>();
            aa = new List<TempClassForOtchet>();

            for (int i = 0; i < 4; i++)
            {
                Random rnd = new Random();
                var temp = rnd.Next(1, 12);
                listForAnswers.Add(clonedInputs[temp]);               
                clonedInputs.RemoveAt(temp);
                listForAnswers2.Add(clonedOutputs[temp]);
                aa.Add(new TempClassForOtchet(clonedInputs[temp], clonedOutputs[temp]));
                clonedOutputs.RemoveAt(temp);
            }

            var list = new List<TempClassForOtchet>();
            for (int i = 0; i < clonedInputs.Count; i++)
                list.Add(new TempClassForOtchet(clonedInputs[i], clonedOutputs[i]));
            dataGridView1.DataSource = list;
            dataGridView1.Columns[2].Visible = false;

            for (int i = 0; i < value; i++)
            {
                neuralNetwork.Learn(outputs, inputs);
                //await Task.Delay(5);
                Console.WriteLine($"обучили {i} из {value}");
            }

            var resultList = new List<TempClassForOtchet>();
            for (int i = 0; i < inputs.Count; i++)
                resultList.Add(new TempClassForOtchet(inputs[i], outputs[i], Math.Round(neuralNetwork.Predict(inputs[i].ToList()), 2)));

            dataGridView2.DataSource = resultList;
            this.Size = new System.Drawing.Size(1200, 800);
        }

        private void dataGridView2_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                var expected = Convert.ToDouble(row.Cells[1].Value);
                var actual = Convert.ToDouble(row.Cells[2].Value);
                var actualMin = actual - 0.02;
                var actualMax = actual + 0.02;
                if (expected < actualMin || expected > actualMax)
                {
                    row.Cells[1].Style.BackColor = Color.IndianRed;
                    row.Cells[2].Style.BackColor = Color.IndianRed;
                }
                else
                {
                    row.Cells[1].Style.BackColor = Color.LightGreen;
                    row.Cells[2].Style.BackColor = Color.LightGreen;
                }

                var value = row.Cells[0].Value.ToString();
                foreach (var obj in aa)
                    if (value == obj.Значения)
                        row.Cells[0].Style.BackColor = Color.Yellow;
            }
        }
    }
}
