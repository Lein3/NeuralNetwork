using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTestsForms
{
    internal class TempClassForOtchet
    {
        public string Значения { get; set; }
        public double Результат { get; set; }
        public double ОтветСети { get; set; }

        public TempClassForOtchet(double[] input, double result, double answer = 0)
        {
            foreach (var value in input)
                Значения += value.ToString() + ",";
            Значения = Значения.Remove(Значения.Length - 1);
            Результат = result;
            ОтветСети = answer;
        }
    }
}
