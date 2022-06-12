using System;
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
            numericUpDown_NeuronsCount.Value = layer.Neurons.Count;

            int x = panel_Neurons.Width;
            int y = 30;
            int index = 1;
            panel_Neurons.Controls.Clear();

            foreach (var neuron in layer.Neurons)
            {
                var control = new NeuronControl(neuron, null, index++);
                var point = new Point(x, y);
                control.Location = point;
                panel_Neurons.Controls.Add(control);
                y += 130;
            }

            panel_Neurons.Invalidate();
        }
    }
}
