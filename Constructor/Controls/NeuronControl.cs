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
    public partial class NeuronControl : UserControl
    {
        public Neuron Neuron { get; set; }
        private Rectangle Ellipse { get; set; }
        public NeuronControl(Neuron neuron)
        {
            InitializeComponent();
            this.Neuron = neuron;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {           
            var pen = new Pen(Color.Black, 2f);
            Ellipse = new Rectangle(5, 5, 60, 60);
            e.Graphics.DrawEllipse(pen, Ellipse);
        }

        public void Fill()
        {
            var bruh = new SolidBrush(Color.Red);
            pictureBox.CreateGraphics().FillEllipse(bruh, Ellipse);
        }
    }
}
