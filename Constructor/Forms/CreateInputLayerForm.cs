using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class CreateInputLayerForm : Form
    {
        public CreateInputLayerForm()
        {
            InitializeComponent();
        }

        protected void DisplayNetwork(Layer layer)
        {         
            int x = panel_neurons.Width / 3;
            int y = 30;
            int index = 1;
            panel_neurons.Controls.Clear();
            foreach (var neuron in layer.Neurons)
            {
                var control = new NeuronControl(neuron, null, index++);
                var point = new Point(x, y);
                control.Location = point;
                control.pictureBox.MouseEnter += onMouseEnter;
                control.pictureBox.MouseLeave += onMouseLeave;
                panel_neurons.Controls.Add(control);
                y += 100;
            }
            panel_neurons.Invalidate();

            var parent = this.ParentForm as AuthorizationForm;
            //parent.button2.Enabled = true;
        }

        protected void onMouseEnter(object sender, EventArgs e)
        {
            currentNeuronControl.Enabled = true;
            var parent = (sender as PictureBox).Parent as NeuronControl;
            parent.Fill();
            var neuron = parent.Neuron;
            currentNeuronControl.UpdateInfo(neuron);
        }

        protected void onMouseLeave(object sender, EventArgs e)
        {
            var parent = (sender as PictureBox).Parent as NeuronControl;
            parent.pictureBox.Invalidate();
        }

        private void button_readFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_fileName.Text = openFileDialog.FileName;
                //NetworkTemplate.LearningData = new LearningData(openFileDialog.FileName, filese);
                NetworkTemplate.path = openFileDialog.FileName;
                var inputNeurons = NetworkTemplate.LearningData.LearningExamples[0].InputSignals.Count;
                NetworkTemplate.Structure = new Structure(inputNeurons, 1, 1);
                NetworkTemplate.NeuralNetwork = new NeuralNetwork(NetworkTemplate.Structure);
                NetworkTemplate.NeuralNetwork.Normalization(NetworkTemplate.LearningData);
                var firstLayer = NetworkTemplate.NeuralNetwork.Layers.First();
                NetworkTemplate.Layers.Clear();
                NetworkTemplate.Layers.Add(firstLayer);
                DisplayNetwork(firstLayer);
            }
        }

        protected void numericUpDown_Neurons_ValueChanged(object sender, EventArgs e)
        {
            var inputNeurons = (int)numericUpDown_Neurons.Value;
            NetworkTemplate.Structure = new Structure(inputNeurons, 1, 1);
            NetworkTemplate.NeuralNetwork = new NeuralNetwork(NetworkTemplate.Structure);
            var firstLayer = NetworkTemplate.NeuralNetwork.Layers.First();
            NetworkTemplate.Layers.Clear();
            NetworkTemplate.Layers.Add(firstLayer);
            DisplayNetwork(firstLayer);
        }
    }
}
