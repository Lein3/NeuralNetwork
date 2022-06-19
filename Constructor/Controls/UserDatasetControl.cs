using NeuralNetworkNamespace;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Constructor
{
    public partial class UserDatasetControl : UserControl
    {
        private Datasets CurrentDataset { get; set; }
        public UserDatasetControl(Datasets dataset)
        {
            InitializeComponent();
            this.Size = MinimumSize;
            CurrentDataset = dataset;
            label_Name.Text = CurrentDataset.Name;
            label_CreationDate.Text = $"Дата создания: {CurrentDataset.CreationDate.ToShortDateString()}";

            using (SqlConnection sqlConnection = new SqlConnection(Connection.db.Value.Database.Connection.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"SELECT TOP(1) * FROM [ДинамическаяЧасть_ПользовательскиеДатасеты].[{dataset.ID_Table}]", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                LearningData learningData = new LearningData(dataSet);
                label_Info.Text = $"Всего {learningData.ParamNamesInput.Count + learningData.ParamNamesOutput.Count} параметров:\n";
                label_Info.Text += String.Join(", ", learningData.ParamNamesInput.Concat(learningData.ParamNamesOutput));
            }
        }

        private void button_Replace_Click(object sender, EventArgs e)
        {
            var parent = ParentForm as UserDatasetsForm;
            parent.PreviousForm.selectedDatasetID = CurrentDataset.ID_Table;
            parent.DialogResult = DialogResult.OK;
            parent.Close();
        }
    }
}
