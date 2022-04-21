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
        public NeuronControl(Neuron neuron)
        {
            InitializeComponent();
            this.Neuron = neuron;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {           
            var pen = new Pen(Color.Black, 5f);
            var ellipse = new Rectangle(this.Width / 4, this.Height / 7, 50, 50);
            e.Graphics.DrawEllipse(pen, ellipse);
        }
    }
}
