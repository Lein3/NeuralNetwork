using System;
using System.Collections.Generic;
using System.IO;
using NeuralNetworkLibrary;
using System.Runtime.Serialization.Formatters.Binary;

namespace MyTestsConsole
{
    internal class Program
    {
        static public Structure structure = new Structure(13, 1, 7);
        static public NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
        static void Main(string[] args)
        {
            //test1();
            //test2();
            test3();
            test4();
            Console.ReadLine();
        }

        private static void test2()
        {
            var binFormatter = new BinaryFormatter();
            using (var file = new FileStream("myFileKire.neural", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(file, neuralNetwork);
            }
        }

        private static void test3()
        {
            using (var file = new FileStream("myFileKire.neural", FileMode.OpenOrCreate))
            {
                var binFormatter = new BinaryFormatter();
                var neuralNetworkFromFile = binFormatter.Deserialize(file) as NeuralNetwork;
                if (neuralNetworkFromFile != null)
                {
                    var templist = new List<double> { 63, 1, 3, 145, 233, 1, 0, 150, 0, 2.3, 0, 0, 1 };
                    var result = neuralNetworkFromFile.Predict(templist);
                    Console.WriteLine(result.ToString());
                }
            }
        }

        static void test1()
        {
            neuralNetwork.Read_Scalling_Learn(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv", 5000, 0.01);
            var templist = new List<double> { 63, 1, 3, 145, 233, 1, 0, 150, 0, 2.3, 0, 0, 1 };
            var result = neuralNetwork.Predict(templist);
            neuralNetwork.Learn_Clear();
            Console.WriteLine(result.ToString());
        }

        static void test4()
        {
            //List<Neuron> rar = new List<Neuron>();
            //NeuronInput kek = new NeuronInput(5, Structure.NeuronType.Input);
            //rar.Add(kek);
            //Console.WriteLine();
        }
    }
}
