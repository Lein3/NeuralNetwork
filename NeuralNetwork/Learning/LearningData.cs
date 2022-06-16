using System;
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
        public List<string> ClassNames { get; set; }
        public Dictionary<string, int> ClassesCount => SelectClassesCountInformation();
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
                List<string> paramNames = streamReader.ReadLine().Split(separator).ToList();
                ParamNamesInput = paramNames.GetRange(0, paramNames.Count - 1);
                ParamNamesOutput = paramNames.GetRange(paramNames.Count - 1, 1);

                while (!streamReader.EndOfStream)
                {
                    List<double> values = streamReader.ReadLine().Split(separator).ToList().ConvertAll(item => Convert.ToDouble(item));
                    List<double> inputSignals = values.GetRange(0, values.Count - 1);
                    List<double> expectedOutputs = values.GetRange(values.Count - 1, 1);
                    LearningExample LearningExample = new LearningExample(inputSignals, expectedOutputs);
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
                LearningExample LearningExample = new LearningExample(temp_inputSignals[i].ToList(), temp_expectedOutputs[i].ToList());
                LearningExamples.Add(LearningExample);
            }
        }

        public LearningData(DataSet dataSet)
        {
            ParamNamesInput = new List<string>();
            ParamNamesOutput = new List<string>();
            LearningExamples = new List<LearningExample>();

            DataTable dataTable = dataSet.Tables[0];
            foreach (DataColumn column in dataTable.Columns)
            {
                ParamNamesInput.Add(column.ColumnName);
            }
            ParamNamesOutput.Add(ParamNamesInput.Last());
            ParamNamesInput.Remove(ParamNamesInput.Last());

            foreach(DataRow row in dataTable.Rows)
            {
                var values = row.ItemArray.Select(item => Convert.ToDouble(item)).ToList();
                var inputSignals = values.GetRange(0, values.Count - 1);
                var expectedOutputs = values.GetRange(values.Count - 1, 1);
                var learningExample = new LearningExample(inputSignals, expectedOutputs);
                LearningExamples.Add(learningExample);
            }
        }

        public void SplitOnLearningAndTestData(int TestPercents)
        {
            if (TestExamples != null)
            {
                LearningExamples = LearningExamples.Union(TestExamples).ToList();
            }

            TestExamples = new List<LearningExample>();
            int count = LearningExamples.Count / 100 * TestPercents;
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(0, LearningExamples.Count);
                TestExamples.Add(LearningExamples[index]);
                LearningExamples.RemoveAt(index);
            }
        }

        public void Mix()
        {
            Random random = new Random(DateTime.Now.Millisecond);
            LearningExamples.OrderBy(item => random.Next());
        }

        public DataSet ConvertToDotNetDataSet()
        {
            DataSet dataSet = new DataSet();
            DataTable dataTableLearning = new DataTable();
            dataSet.Tables.Add(dataTableLearning);
            FillTable(dataTableLearning, LearningExamples);

            if (TestExamples != null)
            {
                DataTable dataTableTest = new DataTable();
                dataSet.Tables.Add(dataTableTest);
                FillTable(dataTableTest, TestExamples);
            }

            return dataSet;
        }

        private void FillTable(DataTable dataTableLearning, List<LearningExample> source)
        {
            foreach (string item in ParamNamesInput.Concat(ParamNamesOutput))
            {
                DataColumn dataColumn = new DataColumn(item);
                dataTableLearning.Columns.Add(dataColumn);
            }
            foreach (LearningExample item in source)
            {
                DataRow dataRow = dataTableLearning.NewRow();
                dataRow.ItemArray = item.InputSignals.Concat(item.ExpectedOutputs).Cast<object>().ToArray();
                dataTableLearning.Rows.Add(dataRow);
            }
        }

        public void SwapToParamOutput(int index)
        {
            try
            {
                (ParamNamesInput[index], ParamNamesOutput[0]) = (ParamNamesOutput[0], ParamNamesInput[index]);

                foreach (LearningExample example in LearningExamples)
                    (example.InputSignals[index], example.ExpectedOutputs[0]) = (example.ExpectedOutputs[0], example.InputSignals[index]);
            }
            catch
            {
                return;
            }
        }

        private Dictionary<string, int> SelectClassesCountInformation()
        {
            if (ParamNamesOutput.Count == 1)
                return GetBinaryClassesCountInformation();
            else
                return GetMultiClassesCountInformation();
        }

        private Dictionary<string, int> GetBinaryClassesCountInformation()
        {
            var dictionary = new Dictionary<string, int>();
            int count0 = 0;
            int count1 = 0;
            if (TestExamples != null)
            {
                count0 = LearningExamples.Concat(TestExamples).Where(item => item.ExpectedOutputs[0] == 0).ToList().Count;
                count1 = LearningExamples.Concat(TestExamples).Where(item => item.ExpectedOutputs[0] == 1).ToList().Count;
            }
            else
            {
                count0 = LearningExamples.Where(item => item.ExpectedOutputs[0] == 0).ToList().Count;
                count1 = LearningExamples.Where(item => item.ExpectedOutputs[0] == 1).ToList().Count;
            }
            dictionary.Add(ClassNames[0], count1);
            dictionary.Add("не " + ClassNames[0], count0);
            return dictionary;
        }

        private Dictionary<string, int> GetMultiClassesCountInformation()
        {
            var dictionary = new Dictionary<string, int>();
            for (int i = 0; i < ClassNames.Count; i++)
            {
                int count;
                if (TestExamples != null)
                {
                    count = LearningExamples.Concat(TestExamples).Where(item => item.ExpectedOutputs[i] == 1).ToList().Count;
                }
                else
                {
                    count = LearningExamples.Where(item => item.ExpectedOutputs[i] == 1).ToList().Count;
                }
                dictionary.Add(ClassNames[i], count);
            }
            return dictionary;
        }
    }
}
