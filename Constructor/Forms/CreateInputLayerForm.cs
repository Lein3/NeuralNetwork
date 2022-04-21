using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetwork;
using NeuralNetworkClass = NeuralNetwork.NeuralNetwork;

namespace Constructor
{
    public partial class CreateInputLayerForm : Form
    {
        public CreateInputLayerForm()
        {
            InitializeComponent();
            LearningData learningData = new LearningData(@"C:\ProgesForC\Dz\UltraSolution\z.csv");
            Structure structure = new Structure(100, 1, 6, 6);
            NeuralNetworkClass neuralNetwork = new NeuralNetworkClass(structure);         
            // neuralNetwork.Normalization(learningData);
            DisplayNetwork(neuralNetwork.Layers.First());
        }

        private void DisplayNetwork(Layer layer)
        {
            int x = panel_Neurons.Width / 2;
            int y = 0;
            foreach (var neuron in layer.Neurons)
            {
                var control = new NeuronControl(neuron);
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
    }
}
