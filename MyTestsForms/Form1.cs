using NeuralNetworkLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTestsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (double i = 2; i < 1000; i += 0.1)
            {
                chart1.Series[0].Points.AddXY(i, Math.Log10(i));
            }

            Structure structure = new Structure(1, 1, 1);
            NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
            var inputSignals = new List<double[]>();
            var expectedOutputs = new List<double[]>();
            for (double i = 100; i < 200; i+= 0.1)
            {
                inputSignals.Add(new double[] { i } );
                expectedOutputs.Add(new double[] { Math.Log(i) });
            }
            LearningData learningData = new LearningData(inputSignals, expectedOutputs);
            neuralNetwork.Normalization(learningData);
            neuralNetwork.Learn(learningData, 5000);

            for (double i = 2; i < 300; i += 0.1)
            {
                var forPredict = new double[] { i };
                List<double> forPredictList = new List<double>(forPredict);
                chart2.Series[0].Points.AddXY(i, neuralNetwork.Predict(forPredictList)["0"]);
            }
        }
    }
}
