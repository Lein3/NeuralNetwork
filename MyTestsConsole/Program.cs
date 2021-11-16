using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NeuralNetworkLibrary;

namespace MyTestsConsole
{
    internal class Program
    {
        static public Structure structure = new Structure(13, 1, 0.01, 7);
        static public NeuralNetwork neuralNetwork = new NeuralNetwork(structure);
        static void Main(string[] args)
        {            
            test1();
            Console.ReadLine();
        }

        static void test1()
        {
            neuralNetwork.Read_Scalling_Learn(@"C:\ProgesForC\Dz\UltraSolution\MyTestsConsole\z.csv", 10000);
            var templist = new List<double> { 45, 1, 1, 119, 264, 0, 1, 172, 0, 0, 2, 0, 3 };
            var result = neuralNetwork.Predict(templist);
            Console.WriteLine(result.ToString());
            Console.ReadLine();
        }
    }
}
