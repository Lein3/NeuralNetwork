using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class LearningStatistics //щас это хуета
    {
        public List<double> Mae { get; set; } // средняя абсолютная ошибка
        public List<double> Mse { get; set; } // средняя квадратичная ошибка
        public List<double> LogLoss { get; set; } // средняя квадратичная ошибка
        public List<double> CurrentStatics { get; set; }

        public LearningStatistics()
        {
            Mae = new List<double>();
            Mse = new List<double>();
            LogLoss = new List<double>();
        }
    }
}
