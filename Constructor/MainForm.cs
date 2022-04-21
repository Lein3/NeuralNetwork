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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Structure structure = new Structure(3, 2, 6, 6);
            NeuralNetwork.NeuralNetwork neuralNetwork = new NeuralNetwork.NeuralNetwork(structure);
            NeuronControl kek = new NeuronControl(neuralNetwork.Layers.First().Neurons.First());
        }
    }
}
