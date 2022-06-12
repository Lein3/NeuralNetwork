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
        }

        private void DisplayNetwork()
        {
            var layer = new Layer(GlobalTemplate.LearningData);

            int x = panel_Neurons.Width / 3;
            int y = 30;
            int index = 1;
            panel_Neurons.Controls.Clear();
            foreach (var neuron in layer.Neurons)
            {
                var control = new NeuronControl(neuron, null, index++);
                var point = new Point(x, y);
                control.Location = point;
                control.pictureBox.MouseEnter += onMouseEnter;
                control.pictureBox.MouseLeave += onMouseLeave;
                panel_Neurons.Controls.Add(control);
                y += 100;
            }
            panel_Neurons.Invalidate();
        }

        private void onMouseEnter(object sender, EventArgs e)
        {
            currentNeuronControl.Enabled = true;
            var parent = (sender as PictureBox).Parent as NeuronControl;
            parent.Fill();
            var neuron = parent.Neuron;
            currentNeuronControl.UpdateInfo(neuron);
        }

        private void onMouseLeave(object sender, EventArgs e)
        {
            var parent = (sender as PictureBox).Parent as NeuronControl;
            parent.pictureBox.Invalidate();
        }
    }
}
