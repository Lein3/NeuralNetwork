using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuralNetworkLibrary;

namespace MyTestsForms
{
    public partial class Form2 : Form
    {
        Structure structure1 = new Structure(3, 1, 0.01, 6, 6);
        Structure structure2 = new Structure(4, 1, 0.01, 6, 6);
        NeuralNetwork neuralNetworkXOR;
        NeuralNetwork neuralNetworkAND;
        List<double> outputs;
        List<double[]> inputs;
        public Form2()
        {
            InitializeComponent();
            neuralNetworkXOR = new NeuralNetwork(structure1);
            outputs = new List<double>() { 0, 1, 1, 0, 1, 0, 0, 1 };
            inputs = new List<double[]>();
            inputs.Add(new double[] { 0, 0, 0 });
            inputs.Add(new double[] { 0, 0, 1 });
            inputs.Add(new double[] { 0, 1, 0 });
            inputs.Add(new double[] { 0, 1, 1 });
            inputs.Add(new double[] { 1, 0, 0 });
            inputs.Add(new double[] { 1, 0, 1 });
            inputs.Add(new double[] { 1, 1, 0 });
            inputs.Add(new double[] { 1, 1, 1 });
            for (int i = 0; i < 10000; i++)
                neuralNetworkXOR.Learn(outputs, inputs);

            neuralNetworkAND = new NeuralNetwork(structure2);
            outputs = new List<double>() { 1, 1, 0,          1, 1, 1, 0,             1, 1, 1, 0,             0, 0, 0};
            inputs = new List<double[]>();
            //inputs.Add(new double[] { 0, 0, 0, 0 });
            inputs.Add(new double[] { 0, 0, 0, 1 });
            inputs.Add(new double[] { 0, 0, 1, 0 });
            inputs.Add(new double[] { 0, 0, 1, 1 });
            inputs.Add(new double[] { 0, 1, 0, 0 });
            inputs.Add(new double[] { 0, 1, 0, 1 });
            inputs.Add(new double[] { 0, 1, 1, 0 });
            inputs.Add(new double[] { 0, 1, 1, 1 });

            inputs.Add(new double[] { 1, 0, 0, 0 });
            inputs.Add(new double[] { 1, 0, 0, 1 });
            inputs.Add(new double[] { 1, 0, 1, 0 });
            inputs.Add(new double[] { 1, 0, 1, 1 });
            inputs.Add(new double[] { 1, 1, 0, 0 });
            inputs.Add(new double[] { 1, 1, 0, 1 });
            inputs.Add(new double[] { 1, 1, 1, 0 });
            //inputs.Add(new double[] { 1, 1, 1, 1 });
            for (int i = 0; i < 10000; i++)
                neuralNetworkAND.Learn(outputs, inputs);

            Console.WriteLine("gotovo");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            List<double> rar = new List<double>();
            rar.Add(Convert.ToDouble(textBox1.Text));
            rar.Add(Convert.ToDouble(textBox2.Text));
            rar.Add(Convert.ToDouble(textBox3.Text));
            var resul = neuralNetworkXOR.Predict(rar);
            button1.Text = resul.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {           
            List<double> rar = new List<double>();
            rar.Add(Convert.ToDouble(textBox1.Text));
            rar.Add(Convert.ToDouble(textBox2.Text));
            rar.Add(Convert.ToDouble(textBox3.Text));
            rar.Add(Convert.ToDouble(textBox4.Text));
            var resul = neuralNetworkAND.Predict(rar);
            button2.Text = resul.ToString();
        }
    }
}
