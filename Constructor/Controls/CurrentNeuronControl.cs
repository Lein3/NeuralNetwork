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

namespace Constructor
{
    public partial class CurrentNeuronControl : UserControl
    {
        public CurrentNeuronControl()
        {
            InitializeComponent();
            this.BackColor = Color.Transparent;
        }

        private void pictureBox_CurrentNeuron_Paint(object sender, PaintEventArgs e)
        {
            var pen = new Pen(Color.Black, 5f);
            var ellipse = new Rectangle(90, 40, 150, 150);
            e.Graphics.DrawEllipse(pen, ellipse);
            Point p1 = new Point(240, 115);
            Point p2 = new Point(305, 115);
            e.Graphics.DrawLine(pen, p1, p2);
        }

        public void UpdateInfo(Neuron neuron)
        {
            label_Name.Text = neuron.Name;
            label_Max.Text = neuron.Max.ToString();
            label_Min.Text = neuron.Min.ToString();
            label_Sum.Text = neuron.Sum == 0 ? string.Empty : neuron.Sum.ToString();
            label_Output.Text = neuron.Output == 0 ? string.Empty : "S = " + neuron.Sum.ToString();
            DrawRelationLines(neuron);
        }

        private void DrawRelationLines(Neuron neuron)
        {
            if (neuron.NeuronType == Structure.NeuronType.Input)
            {
                var pen = new Pen(Color.Black, 5f);
                Point p1 = new Point(30, 115);
                Point p2 = new Point(90, 115);
                pictureBox_CurrentNeuron.CreateGraphics().DrawLine(pen, p1, p2);
                pictureBox_CurrentNeuron.Invalidate();
            }

        }
    }
}
