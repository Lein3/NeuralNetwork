using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NeuralNetwork
{
    public class LearningData
    {
        public List<string> ParamNamesInput { get; set; }
        public List<string> ParamNamesOutput { get; set; }
        public List<LearningExample> LearningExamples { get; set; }
        public List<LearningExample> TestExamples { get; set; }

        public LearningData(string path)
        {
            LearningExamples = new List<LearningExample>();
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
                    LearningExamples.Add(LearningExample);
                }
            }
        }

        public LearningData(string path, int TestPercents) : this(path)
        {
            TestExamples = new List<LearningExample>();
            var count = LearningExamples.Count / 100 * TestPercents;
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                var index = random.Next(0, LearningExamples.Count);
                TestExamples.Add(LearningExamples[index]);
                LearningExamples.RemoveAt(index);
            }
        }

        public LearningData(List<double[]> temp_inputSignals, List<double[]> temp_expectedOutputs)
        {
            if (temp_inputSignals.Count != temp_expectedOutputs.Count)
                throw new Exception();

            LearningExamples = new List<LearningExample>();
            for (int i = 0; i < temp_inputSignals.Count; i++)
            {
                var LearningExample = new LearningExample(temp_inputSignals[i].ToList(), temp_expectedOutputs[i].ToList());
                LearningExamples.Add(LearningExample);
            }
        }

        public void Mix()
        {
            var random = new Random(DateTime.Now.Millisecond);
            LearningExamples.OrderBy(item => random.Next());
        }
    }
}
