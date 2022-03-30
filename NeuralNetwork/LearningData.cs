using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworkLibrary
{
    public class LearningData
    {
        public List<LearningExample> examples { get; set; }

        public LearningData(string path)
        {
            examples = new List<LearningExample>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                streamReader.ReadLine();
                while (!streamReader.EndOfStream)
                {
                    List<double> values = streamReader.ReadLine().Split(',').ToList().ConvertAll(a => Convert.ToDouble(a.Replace('.', ',')));
                    var inputSignals = values.GetRange(0, values.Count - 1);
                    var expectedOutputs = values.GetRange(values.Count - 1, 1);
                    var LearningExample = new LearningExample(inputSignals, expectedOutputs);
                    examples.Add(LearningExample);
                }
            }
        }

        public LearningData(List<double[]> temp_inputSignals, List<double[]> temp_expectedOutputs)
        {
            if (temp_inputSignals.Count != temp_expectedOutputs.Count)
                throw new Exception();

            examples = new List<LearningExample>();
            for (int i = 0; i < temp_inputSignals.Count; i++)
            {
                var LearningExample = new LearningExample(temp_inputSignals[i].ToList(), temp_expectedOutputs[i].ToList());
                examples.Add(LearningExample);
            }
        }

        public void Mix()
        {
            var random = new Random(DateTime.Now.Millisecond);
            examples.OrderBy(item => random.Next());
        }
    }
}
