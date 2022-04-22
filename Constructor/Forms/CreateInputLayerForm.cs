using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworkNamespace;
using NeuralNetworkClass = NeuralNetworkNamespace.NeuralNetwork;

namespace Constructor
{
    public partial class CreateInputLayerForm : Form
    {
        public CreateInputLayerForm()
        {
            InitializeComponent();
        }

        private void DisplayNetwork(Layer layer)
        {
            int x = panel_Neurons.Width / 2;
            int y = 30;
            int index = 1;
            foreach (var neuron in layer.Neurons)
            {
                var control = new NeuronControl(neuron, index++);
                var point = new Point(x, y);
                control.Location = point;
                control.pictureBox.MouseEnter += onMouseEnter;
                control.pictureBox.MouseLeave += onMouseLeave;
                panel_Neurons.Controls.Add(control);
                y += 100;
            }
        }

        private void onMouseEnter(object sender, EventArgs e)
        {
            currentNeuronControl1.Enabled = true;
            var parent = (sender as PictureBox).Parent as NeuronControl;
            parent.Fill();
            var neuron = parent.Neuron;
            currentNeuronControl1.UpdateInfo(neuron);
        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            var parent = (sender as PictureBox).Parent as NeuronControl;
            parent.pictureBox.Invalidate();
        }

        private void button_readFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                label_fileName.Text = openFileDialog.FileName;
                NetworkTemplate.LearningData = new LearningData(openFileDialog.FileName);
                var inputNeurons = NetworkTemplate.LearningData.LearningExamples[0].InputSignals.Count;
                NetworkTemplate.Structure = new Structure(inputNeurons, 1, 1);
                NetworkTemplate.NeuralNetwork = new NeuralNetwork(NetworkTemplate.Structure);
                NetworkTemplate.NeuralNetwork.Normalization(NetworkTemplate.LearningData);
                DisplayNetwork(NetworkTemplate.NeuralNetwork.Layers.First());
            }
        }
    }
}
