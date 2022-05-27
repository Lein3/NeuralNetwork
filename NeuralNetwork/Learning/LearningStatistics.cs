using System.Collections.Generic;

namespace NeuralNetworkNamespace
{
    public class LearningStatistics //щас это хуета
    {
        public List<double> MAE { get; set; } // средняя абсолютная ошибка
        public List<double> MSE { get; set; } // средняя квадратичная ошибка
        public List<double> LogLoss { get; set; } // средняя квадратичная ошибка

        public LearningStatistics()
        {
            MAE = new List<double>();
            MSE = new List<double>();
            LogLoss = new List<double>();
        }
    }
}
