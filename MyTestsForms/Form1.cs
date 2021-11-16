using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NeuralNetworkLibrary;

namespace MyTestsForms
{
    public partial class Form1 : Form
    {
        
        //импорт функции
        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        NeuralNetwork neuralNetwork;
        List<double[]> inputs = new List<double[]>();
        List<double> outputs = new List<double>();      

        public Form1()
        {
            InitializeComponent();
            inputs.Add(new double[] { 1, 0 });
            outputs.Add(0);
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Structure structure = new Structure(2, 1, 3, 2, 2);
            neuralNetwork = new NeuralNetwork(structure);
        }

        private void button_display_Click(object sender, EventArgs e)
        {            

            label1.Text = Math.Round(neuralNetwork.layers[0].neurons[0].weights[0], 2).ToString();
            button1.Text = Math.Round(neuralNetwork.layers[0].neurons[0].output, 2).ToString();

            label2.Text = Math.Round(neuralNetwork.layers[0].neurons[1].weights[0], 2).ToString();
            button2.Text = Math.Round(neuralNetwork.layers[0].neurons[1].output, 2).ToString();

            label3.Text = Math.Round(neuralNetwork.layers[1].neurons[0].weights[0], 2).ToString();
            label4.Text = Math.Round(neuralNetwork.layers[1].neurons[0].weights[1], 2).ToString();
            label16.Text = Math.Round(neuralNetwork.layers[1].neurons[0].delta, 2).ToString();
            button3.Text = Math.Round(neuralNetwork.layers[1].neurons[0].output, 2).ToString();

            label5.Text = Math.Round(neuralNetwork.layers[1].neurons[1].weights[0], 2).ToString();
            label6.Text = Math.Round(neuralNetwork.layers[1].neurons[1].weights[1], 2).ToString();
            label17.Text = Math.Round(neuralNetwork.layers[1].neurons[1].delta, 2).ToString();
            button4.Text = Math.Round(neuralNetwork.layers[1].neurons[1].output, 2).ToString();

            label7.Text = Math.Round(neuralNetwork.layers[2].neurons[0].weights[0], 2).ToString();
            label8.Text = Math.Round(neuralNetwork.layers[2].neurons[0].weights[1], 2).ToString();
            label14.Text = Math.Round(neuralNetwork.layers[2].neurons[0].delta, 2).ToString();
            button5.Text = Math.Round(neuralNetwork.layers[2].neurons[0].output, 2).ToString();

            label9.Text = Math.Round(neuralNetwork.layers[2].neurons[1].weights[0], 2).ToString();
            label10.Text = Math.Round(neuralNetwork.layers[2].neurons[1].weights[1], 2).ToString();
            label15.Text = Math.Round(neuralNetwork.layers[2].neurons[1].delta, 2).ToString();
            button6.Text = Math.Round(neuralNetwork.layers[2].neurons[1].output, 2).ToString();

            label11.Text = Math.Round(neuralNetwork.layers[3].neurons[0].weights[0], 2).ToString();
            label12.Text = Math.Round(neuralNetwork.layers[3].neurons[0].weights[1], 2).ToString();
            label13.Text = Math.Round(neuralNetwork.layers[3].neurons[0].delta,2).ToString();
            button7.Text = Math.Round(neuralNetwork.layers[3].neurons[0].output, 2).ToString();

        }

        private void button_recalculateError_Click(object sender, EventArgs e)
        {
            neuralNetwork.Learn(outputs, inputs);
            button_display_Click(sender, e);
        }

        private void button_recalculateWeights_Click(object sender, EventArgs e)
        {
            var result = neuralNetwork.Predict(new List<double> { 1, 0 });
            button_recalculateWeights.Text = result.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            inputs = new List<double[]>();
            outputs = new List<double>();
            inputs.Add(new double[] { 0.1, 0.1 });
            outputs.Add(0);
            for (int i = 0; i < 10000; i++)
                neuralNetwork.Learn(outputs, inputs);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            inputs = new List<double[]>();
            outputs = new List<double>();
            inputs.Add(new double[] { 1, 1 });
            outputs.Add(1);
            for (int i = 0; i < 10000; i++)
                neuralNetwork.Learn(outputs, inputs);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            inputs = new List<double[]>();
            outputs = new List<double>();
            inputs.Add(new double[] { 1, 0 });
            outputs.Add(1);
            for (int i = 0; i < 10000; i++)
                neuralNetwork.Learn(outputs, inputs);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<double> rar = new List<double>();
            rar.Add(Convert.ToDouble(textBox1.Text));
            rar.Add(Convert.ToDouble(textBox2.Text));
            var resul = neuralNetwork.Predict(rar);
            button11.Text = resul.ToString();
        }
    }
}
