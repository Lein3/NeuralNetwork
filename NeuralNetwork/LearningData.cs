using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NeuralNetworkLibrary
{
    public class LearningData
    {
        public List<string> ParamNamesInput { get; set; }
        public List<string> ParamNamesOutput { get; set; }
        public List<LearningExample> Examples { get; set; }

        public LearningData(string path)
        {
            Examples = new List<LearningExample>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                var paramNames = streamReader.ReadLine().Split(',').ToList();
                ParamNamesInput = paramNames.GetRange(0, paramNames.Count - 1);
                ParamNamesOutput = paramNames.GetRange(paramNames.Count - 1, 1);

                while (!streamReader.EndOfStream)
                {
                    List<double> values = streamReader.ReadLine().Split(',').ToList().ConvertAll(a => Convert.ToDouble(a.Replace('.', ',')));
                    var inputSignals = values.GetRange(0, values.Count - 1);
                    var expectedOutputs = values.GetRange(values.Count - 1, 1);
                    var LearningExample = new LearningExample(inputSignals, expectedOutputs);
                    Examples.Add(LearningExample);
                }
            }
        }

        public LearningData(List<double[]> temp_inputSignals, List<double[]> temp_expectedOutputs)
        {
            if (temp_inputSignals.Count != temp_expectedOutputs.Count)
                throw new Exception();

            Examples = new List<LearningExample>();
            for (int i = 0; i < temp_inputSignals.Count; i++)
            {
                var LearningExample = new LearningExample(temp_inputSignals[i].ToList(), temp_expectedOutputs[i].ToList());
                Examples.Add(LearningExample);
            }
        }

        public void Mix()
        {
            var random = new Random(DateTime.Now.Millisecond);
            Examples.OrderBy(item => random.Next());
        }
    }
}
