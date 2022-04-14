using System;
using System.Collections.Generic;

namespace NeuralNetworkLibrary
{
    [Serializable]
    public abstract class Neuron
    {
        public List<double> Weights { get; }
        public List<double> Inputs { get; set; }
        public Structure.NeuronType NeuronType { get; set; }
        public double Output { get; set; }
        public double Error { get; set; }
        public double Sum { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }
        public string Name { get; set; }
        protected static Random Rnd { get; set; } = new Random(DateTime.Now.Millisecond); //сука рандом не трожь все по пизде пойдет

        public Neuron()
        {           
            Weights = new List<double>();
            Inputs = new List<double>();
            Min = 0;
            Max = 1;
        }

        public virtual double ProcessInformation(List<double> original_inputs)
        {
            return Output;
        }

        public virtual void Learn_ChangeWeights(double learningRate)
        {
            
        }

        protected double Sigmoid(double x)
        {
            double result = 1 / (1 + Math.Exp(-x));
            return result;
        }

        protected double SigmoidDx(double x)
        {
            double result = Sigmoid(x) * (1 - Sigmoid(x));
            return result;
        }
    }
}
