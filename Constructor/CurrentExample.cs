using NeuralNetworkNamespace;

namespace Constructor
{
    internal class CurrentExample
    {
        public double Возраст { get; set; }
        public double Пол { get; set; }
        public double БольГруди { get; set; }
        public double АртериальноеДавление { get; set; }
        public double УровеньХолестерина { get; set; }
        public double УровеньСахара { get; set; }
        public double ЭКГ { get; set; }
        public double МаксимальныеСердечныеСокращения { get; set; }
        public double Стенокардия { get; set; }
        public double StРасстройство { get; set; }
        public double НаклонSt { get; set; }
        public double КрупныеСосуды { get; set; }
        public double Талассемия { get; set; }
        public double ОжидаемоеЗначение { get; set; }
        public double ОтветСети { get; set; }

        public CurrentExample(LearningExample example, double answer = 0)
        {
            Возраст = example.InputSignals[0];
            Пол = example.InputSignals[1];
            БольГруди = example.InputSignals[2];
            АртериальноеДавление = example.InputSignals[3];
            УровеньХолестерина = example.InputSignals[4];
            УровеньСахара = example.InputSignals[5];
            ЭКГ = example.InputSignals[6];
            МаксимальныеСердечныеСокращения = example.InputSignals[7];
            Стенокардия = example.InputSignals[8];
            StРасстройство = example.InputSignals[9];
            НаклонSt = example.InputSignals[10];
            КрупныеСосуды = example.InputSignals[11];
            Талассемия = example.InputSignals[12];

            ОжидаемоеЗначение = example.ExpectedOutputs[0];
            ОтветСети = answer;
        }
    }
}
