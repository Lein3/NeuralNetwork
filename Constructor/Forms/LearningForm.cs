using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class LearningForm : Form
    {
        public LearningForm()
        {
            InitializeComponent();
            label_fileName.Text = NetworkTemplate.path ?? "файл не выбран";
            NetworkTemplate.Structure = new Structure();
            NetworkTemplate.NeuralNetwork = new NeuralNetwork(NetworkTemplate.Layers);
            UpdateAllLayers();
        }

        private void UpdateAllLayers()
        {
            panel_neurons.Controls.Clear();
            DrawAllLayers();
        }

        private void DrawAllLayers()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)delegate
                {
                    panel_neurons.Controls.Clear();
                });
            }
            else
            {
                panel_neurons.Controls.Clear();
            }

            int x = 10;
            int y = 30;
            int index = 1;
            foreach (var layer in NetworkTemplate.NeuralNetwork.Layers)
            {
                foreach (var neuron in layer.Neurons)
                {
                    var control = new NeuronControl(neuron, neuron.Error, index++);
                    var point = new Point(x, y);
                    control.Location = point;
                    if (InvokeRequired)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            panel_neurons.Controls.Add(control);
                        });
                    }
                    else
                    {
                        panel_neurons.Controls.Add(control);
                    }
                    y += 100;                  
                }
                x += 100;
                y = 30;
            }
        }

        private void DrawSeparator(object sender, PaintEventArgs e)
        {
            try
            {
                var pen = new Pen(Color.Black, 5f);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                var firstNeuron = panel_neurons.Controls.OfType<NeuronControl>().First();
                var postionX = firstNeuron.Location.X + firstNeuron.Width + 20;
                var postionY = firstNeuron.Location.Y;
                var point1 = new Point(postionX, postionY);
                var point2 = new Point(postionX, panel_neurons.Height);
                e.Graphics.DrawLine(pen, point1, point2);

                if (NetworkTemplate.Layers.Last().Neurons.Last().NeuronType == Structure.NeuronType.Output)
                {
                    var lastNeuron = panel_neurons.Controls.OfType<NeuronControl>().Last();
                    var postionX2 = lastNeuron.Location.X - 15;
                    var postionY2 = lastNeuron.Location.Y;
                    var point3 = new Point(postionX2, postionY);
                    var point4 = new Point(postionX2, panel_neurons.Height);
                    e.Graphics.DrawLine(pen, point3, point4);
                }
            }
            catch
            {

            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_errorBarrier.Checked == true)
            {
                numericUpDown_errorBarier.Enabled = true;
                numericUpDown_learningCount.Enabled = false;
            }

            if (radioButton_learningCount.Checked == true)
            {
                numericUpDown_errorBarier.Enabled = false;
                numericUpDown_learningCount.Enabled = true;
            }
                
        }

        private void button_readFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_fileName.Text = openFileDialog.FileName;
                NetworkTemplate.LearningData = new LearningData(openFileDialog.FileName, (int)numericUpDown_percent.Value);
                NetworkTemplate.path = openFileDialog.FileName;              
                LoadDataset();             
            }
        }

        private async void button_start_Click(object sender, EventArgs e)
        {
            NetworkTemplate.NeuralNetwork = new NeuralNetwork(NetworkTemplate.Layers);
            var count = (int)numericUpDown_learningCount.Value;
            var learningRate = (double)numericUpDown_learningRate.Value;
            await Task.Run(() =>
            {
                for (int i = 0; i < count; i++)
                {
                    NetworkTemplate.NeuralNetwork.Learn_Backpropogation(NetworkTemplate.LearningData, 1, learningRate);
                    Console.WriteLine($"обучили {i} из {count} средняя абсолютная ошибка: {NetworkTemplate.NeuralNetwork.LearningStatistics.MAE.Last()}");
                    if (i % 500 == 0)
                    {
                        DrawAllLayers();
                    }
                }
            });
            var parent = this.ParentForm as SelectModeAndAuthorizationForm;
            //parent.button5.Enabled = true;
            //parent.button5_Click(null, null);
        }

        private void button_dataset_Click(object sender, EventArgs e)
        {
            if (NetworkTemplate.path == null)
                MessageBox.Show("не выбраны данные");
            else
            {
                NetworkTemplate.LearningData = new LearningData(NetworkTemplate.path, (int)numericUpDown_percent.Value);
                LoadDataset();
            }
            button_start.Enabled = true;
        }

        private void LoadDataset()
        {
            //var listLearning = new List<CurrentExample>();
            //foreach (var example in NetworkTemplate.LearningData.LearningExamples)
            //    listLearning.Add(new CurrentExample(example));
            //dataGridView_learningData.DataSource = listLearning;
            //dataGridView_learningData.Columns[14].Visible = false;
            //label_learningCount.Text = listLearning.Count.ToString();

            //var listTest = new List<CurrentExample>();
            //foreach (var example in NetworkTemplate.LearningData.TestExamples)
            //    listTest.Add(new CurrentExample(example));
            //dataGridView_testData.DataSource = listTest;
            //dataGridView_testData.Columns[14].Visible = false;
            //label_testCount.Text = listTest.Count.ToString();
        }
    }
}
