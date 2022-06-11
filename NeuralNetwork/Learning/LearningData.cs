﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace NeuralNetworkNamespace
{
    public class LearningData
    {
        public List<string> ParamNamesInput { get; set; }
        public List<string> ParamNamesOutput { get; set; }
        public List<LearningExample> LearningExamples { get; set; }
        public List<LearningExample> TestExamples { get; set; }

        public LearningData()
        {
            
        }

        public LearningData(string path, char separator)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            LearningExamples = new List<LearningExample>();
            using (StreamReader streamReader = new StreamReader(path))
            {
                var paramNames = streamReader.ReadLine().Split(separator).ToList();
                ParamNamesInput = paramNames.GetRange(0, paramNames.Count - 1);
                ParamNamesOutput = paramNames.GetRange(paramNames.Count - 1, 1);

                while (!streamReader.EndOfStream)
                {
                    List<double> values = streamReader.ReadLine().Split(separator).ToList().ConvertAll(item => Convert.ToDouble(item));
                    var inputSignals = values.GetRange(0, values.Count - 1);
                    var expectedOutputs = values.GetRange(values.Count - 1, 1);
                    var LearningExample = new LearningExample(inputSignals, expectedOutputs);
                    LearningExamples.Add(LearningExample);
                }
            }
        }

        public LearningData(string path, char separator, int TestPercents) : this(path, separator)
        {
            SplitOnLearningAndTestData(TestPercents);
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

        public void SplitOnLearningAndTestData(int TestPercents)
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

        public void Mix()
        {
            var random = new Random(DateTime.Now.Millisecond);
            LearningExamples.OrderBy(item => random.Next());
        }

        public DataSet ConvertToDotNetDataSet()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();
            dataSet.Tables.Add(dataTable);

            foreach (string item in ParamNamesInput.Concat(ParamNamesOutput))
            {
                DataColumn dataColumn = new DataColumn(item);
                dataTable.Columns.Add(dataColumn);
            }
            foreach (LearningExample item in LearningExamples)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow.ItemArray = item.InputSignals.Concat(item.ExpectedOutputs).Cast<object>().ToArray();
                dataTable.Rows.Add(dataRow);
            }

            return dataSet;
        }

        public void SwapToParamOutput(int index)
        {
            (ParamNamesInput[index], ParamNamesOutput[0]) = (ParamNamesOutput[0], ParamNamesInput[index]);

            foreach (var example in LearningExamples)
                (example.InputSignals[index], example.ExpectedOutputs[0]) = (example.ExpectedOutputs[0], example.InputSignals[index]);
        }
    }
}
