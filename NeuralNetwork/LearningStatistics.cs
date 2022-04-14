using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLibrary
{
    public class LearningStatistics
    {
        public List<double> SSE { get; set; } //сумма квадратов
        public List<double> MAE { get; set; } // средняя абсолютная ошибка
        public List<double> MSE { get; set; } // средняя квадратичная ошибка
        public List<double> RSE { get; set; } //
        public List<double> MSEREG { get; set; } // комбинированная ошибка
        public List<double> MLE { get; set; } // оценка максимального правдоподобия
        public List<double> MAP { get; set; } // Максимальная апостериорная оценка

        public LearningStatistics()
        {
            MAE = new List<double>();
            MSE = new List<double>();
        }
    }
}
