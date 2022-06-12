using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class NetworkConfigurationForm : Form
    {
        public NetworkConfigurationForm()
        {
            InitializeComponent();
            DisplayNetwork();
            if (GlobalTemplate.CurrentWorkMode == GlobalTemplate.WorkMode.freeMode)
            {
                numericUpDown_NeuronsCount.Enabled = true;
            }
        }

        private void DisplayNetwork()
        {
            GlobalTemplate.LearningData = new LearningData(@"C:\ProgesForC\Dz\NeuralNetwork\болезни2.csv", ',');
            var layer = new Layer(GlobalTemplate.LearningData);
            layer.Neurons.Add(new Neuron_Bias());
            numericUpDown_NeuronsCount.Value = layer.Neurons.Count;

            int x = panel_Neurons.Width;
            int y = 30;
            int index = 1;
            panel_Neurons.Controls.Clear();

            foreach (var layer in layer)
            {
                foreach (var neuron in clayer.Neurons)
                {
                    var control = new NeuronControl(neuron, 5, index++);
                    var point = new Point(x, y);
                    control.Location = point;
                    panel_Neurons.Controls.Add(control);
                    y += 130;
                }
                x += 100;
                y = 30;
            }

            panel_Neurons.Invalidate();
        }
    }
}
