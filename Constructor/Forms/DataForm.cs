using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class DataForm : Form
    {
        private LearningData learningData { get; set; }
        private Point ActivePanelLocation { get; set; } = new Point(300, 150);
        private char FileSeparator { get; set; } = ';';
        private SqlConnectionStringBuilder dynamicSqlConnectionStringBuilder { get; set; }
        private SqlConnectionStringBuilder localSqlConnectionStringBuilder { get; set; } = new SqlConnectionStringBuilder("Data Source=localhost;Initial Catalog=NeuralNetworkConstructor;Integrated Security=True");

        public DataForm()
        {
            InitializeComponent();
            panel_FromFile.Location = ActivePanelLocation;
            panel_FromDatabase.Location = ActivePanelLocation;
            panel_FromPublicDataset.Location = ActivePanelLocation;
            panel_FromPrivateDataset.Location = ActivePanelLocation;
            // в конструкторе панели расположены в целях удобства редактирования тут мы их перемещаем на рабочее место

            if (GlobalTemplate.CurrentUser != null)
            {
                radioButton4.Enabled = true;
            }
        }

        #region Из Файла
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromFile.Visible = true;
        }

        private void button_FromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_FilePath.Text = openFileDialog.FileName;
            using (StreamReader streamReader = new StreamReader(openFileDialog.FileName))
            {
                var firstLine = streamReader.ReadLine();
                if (firstLine.Contains(';'))
                {
                    radioButton_Separator1.Checked = true;
                }
                else if (firstLine.Contains(','))
                {
                    radioButton_Separator2.Checked = true;
                }
            }
            learningData = new LearningData(openFileDialog.FileName, FileSeparator);
            dataGridView.DataSource = learningData.ConvertToDotNetDataSet().Tables[0];

            var paramsNames = learningData.ParamNamesInput.Concat(learningData.ParamNamesOutput).ToList();
            comboBox_PredictMark.DataSource = paramsNames;
            comboBox_PredictMark.SelectedIndex = comboBox_PredictMark.Items.Count - 1;
        }
        #endregion

        #region Из Источника Данных
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromDatabase.Visible = true;
        }

        private void button_SelectDataSource_Click(object sender, EventArgs e)
        {
            DataConnectionDialog d = new DataConnectionDialog();
            DataSource.AddStandardDataSources(d);
            if (DataConnectionDialog.Show(d) != DialogResult.OK)
            {
                return;
            }

            dynamicSqlConnectionStringBuilder = new SqlConnectionStringBuilder(d.ConnectionString);
            label_DataSourceName.Text = dynamicSqlConnectionStringBuilder.InitialCatalog;
            comboBox_SelectDatasetFromDataSource.DataSource = GetDatasetsFromDataSource();
        }

        private List<string> GetDatasetsFromDataSource()
        {
            using (SqlConnection sqlConnection = new SqlConnection(dynamicSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT name FROM sys.tables", sqlConnection);
                var SelectedTables = sqlCommand.ExecuteReader();
                var TableNames = new List<string>();
                while (SelectedTables.Read())
                {
                    TableNames.Add(SelectedTables.GetString(0));
                }
                return TableNames;
            }
        }

        private void comboBox_SelectDatasetsFromDataSource_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var tableName = comboBox_SelectDatasetFromDataSource.GetItemText(comboBox_SelectDatasetFromDataSource.SelectedItem); //по другому не обновляется либо криво идет
            using (SqlConnection sqlConnection = new SqlConnection(dynamicSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM [{tableName}]", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];
            }
        }
        #endregion

        #region Датасеты Нашей Базы
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromPublicDataset.Visible = true;
            comboBox_SelectPublicDataset.DataSource = GetDatasetsFromLocalDatabase(null).ToList();
            comboBox_SelectPublicDataset.DisplayMember = "Name";
            comboBox_SelectPublicDataset.ValueMember = "ID_Table";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromPrivateDataset.Visible = true;
            comboBox_SelectPrivateDataset.DataSource = GetDatasetsFromLocalDatabase(GlobalTemplate.CurrentUser.ID).ToList();
            comboBox_SelectPrivateDataset.DisplayMember = "Name";
            comboBox_SelectPrivateDataset.ValueMember = "ID_Table";
        }

        private IQueryable<Datasets> GetDatasetsFromLocalDatabase(Nullable<int> id_Owner)
        {
            var Datasets = Connection.db.Value.Datasets.Where(item => item.Owner == id_Owner);
            return Datasets;
        }

        private void comboBox_SelectDatasetFromLocalDatabase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var tableName = (sender as ComboBox).SelectedValue.ToString();        
            using (SqlConnection sqlConnection = new SqlConnection(localSqlConnectionStringBuilder.ConnectionString))
            {
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM [ДинамическаяЧасть_ПользовательскиеДатасеты].[{tableName}]", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];
            }
        }
        #endregion

        #region Остальное
        private void SetAllPanelsInvisible()
        {
            foreach (var panel in this.Controls.OfType<Panel>())
                panel.Visible = false;
        }

        private void radioButton_Separator1_CheckedChanged(object sender, EventArgs e)
        {
            FileSeparator = ';';
        }

        private void radioButton_Separator2_CheckedChanged(object sender, EventArgs e)
        {
            FileSeparator = ',';
        }
        #endregion

        private void comboBox_PredictMark_SelectionChangeCommitted(object sender, EventArgs e)
        {
            learningData.SwapToParamOutput(comboBox_PredictMark.SelectedIndex);
            dataGridView.DataSource = null;
            dataGridView.DataSource = learningData.ConvertToDotNetDataSet().Tables[0];

            var paramsNames = learningData.ParamNamesInput.Concat(learningData.ParamNamesOutput).ToList();
            comboBox_PredictMark.DataSource = paramsNames;
            comboBox_PredictMark.SelectedIndex = comboBox_PredictMark.Items.Count - 1;
        }
    }
}
