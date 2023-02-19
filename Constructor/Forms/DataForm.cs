using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using NeuralNetworkNamespace;

namespace Constructor
{
    public partial class DataForm : Form
    {
        public LearningData LearningData { get; set; }
        private Point ActivePanelLocation { get; set; } = new Point(300, 150);
        private char FileSeparator { get; set; } = ';';
        private SqlConnectionStringBuilder DynamicSqlConnectionStringBuilder { get; set; }
        private SqlConnectionStringBuilder LocalSqlConnectionStringBuilder { get; set; } = new SqlConnectionStringBuilder("Data Source=localhost;Initial Catalog=NeuralNetworkConstructor;Integrated Security=True");

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
            if (GlobalTemplate.CurrentScenario == GlobalTemplate.Scenario.binaryClassification)
            {
                predictMarkControl0.button_AddMark.Visible = false;
                predictMarkControl0.button_RemoveMark.Visible = false;
            }
        }

        public DataForm(int dataset)
        {
            InitializeComponent();
            panel_FromFile.Location = ActivePanelLocation;
            panel_FromDatabase.Location = ActivePanelLocation;
            panel_FromPublicDataset.Location = ActivePanelLocation;
            panel_FromPrivateDataset.Location = ActivePanelLocation;
            // в конструкторе панели расположены в целях удобства редактирования тут мы их перемещаем на рабочее место
            radioButton4.Enabled = true;
            radioButton4.Checked = true;

            using (SqlConnection sqlConnection = new SqlConnection(LocalSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM [ДинамическаяЧасть_ПользовательскиеДатасеты].[{dataset}]", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView.DataSource = null;
                dataGridView.DataSource = dataSet.Tables[0];
                LearningData = new LearningData(dataSet);
                predictMarkControl0.Visible = true;
                FirstUpdateComboBoxPredictMark();
            }
        }

        #region Из Файла
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromFile.Visible = true;
            textBox_FilePath.Text = String.Empty;
            textBox_FromFileSaveName.Text = String.Empty;
        }

        private void button_FromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "CSV (*.csv)|*.csv|TSV (*.tsv)|*.tsv|TXT (*.txt)|*.txt|All files (*.*)|*.*" };
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
            LearningData = new LearningData(openFileDialog.FileName, FileSeparator);
            dataGridView.DataSource = LearningData.ConvertToDotNetDataSet().Tables[0];
            textBox_FromFileSaveName.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            predictMarkControl0.Visible = true;
            FirstUpdateComboBoxPredictMark();
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

            DynamicSqlConnectionStringBuilder = new SqlConnectionStringBuilder(d.ConnectionString);
            label_DataSourceName.Text = DynamicSqlConnectionStringBuilder.InitialCatalog;
            comboBox_SelectDatasetFromDataSource.DataSource = GetDatasetsFromDataSource();
        }

        private List<string> GetDatasetsFromDataSource()
        {
            using (SqlConnection sqlConnection = new SqlConnection(DynamicSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME != 'sysdiagrams'", sqlConnection);
                var selectedTables = sqlCommand.ExecuteReader();
                var tableNames = new List<string>();
                while (selectedTables.Read())
                {
                    tableNames.Add(selectedTables.GetString(0));
                }
                return tableNames;
            }
        }

        private void comboBox_SelectDatasetsFromDataSource_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var tableName = comboBox_SelectDatasetFromDataSource.GetItemText(comboBox_SelectDatasetFromDataSource.SelectedItem); //по другому не обновляется либо криво идет
            using (SqlConnection sqlConnection = new SqlConnection(DynamicSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM [{tableName}]", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView.DataSource = dataSet.Tables[0];
                try
                {
                    LearningData = new LearningData(dataSet);
                    predictMarkControl0.Visible = true;
                    FirstUpdateComboBoxPredictMark();
                }
                catch (Exception)
                {
                    predictMarkControl0.comboBox_PredictMark.DataSource = null;
                    MessageBox.Show("Выбранный набор данных не может быть выбран для обучения нейронной сети");
                }
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

        private IQueryable<Datasets> GetDatasetsFromLocalDatabase(Nullable<int> idOwner)
        {
            var datasets = Connection.Db.Value.Datasets.Where(item => item.Owner == idOwner).OrderBy(item => item.Name);
            return datasets;
        }

        private void comboBox_SelectDatasetFromLocalDatabase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var tableName = (sender as ComboBox).SelectedValue.ToString();        
            using (SqlConnection sqlConnection = new SqlConnection(LocalSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM [ДинамическаяЧасть_ПользовательскиеДатасеты].[{tableName}]", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView.DataSource = null;
                dataGridView.DataSource = dataSet.Tables[0];
                LearningData = new LearningData(dataSet);
                predictMarkControl0.Visible = true;
                FirstUpdateComboBoxPredictMark();
            }
        }
        #endregion

        #region Остальное
        private void SetAllPanelsInvisible()
        {
            foreach (var panel in this.Controls.OfType<Panel>())
                panel.Visible = false;
            foreach (var predictMarkControl in this.Controls.OfType<PredictMarkControl>().Skip(1))
                Controls.Remove(predictMarkControl);
            predictMarkControl0.comboBox_PredictMark.DataSource = null;
            predictMarkControl0.textBox_PredictMarkName.Text = String.Empty;
        }

        public void FirstUpdateComboBoxPredictMark()
        {
            label_DataPreviewInfo.Text = $"Всего {LearningData.ParamNamesInput.Count + LearningData.ParamNamesOutput.Count} параметров";
            label_DataPreviewInfo.Text += $" и {LearningData.LearningExamples.Count} пример(ов) ";

            var paramsNames = LearningData.ParamNamesInput.Concat(LearningData.ParamNamesOutput).ToList();
            predictMarkControl0.button_AddMark.Enabled = true;
            predictMarkControl0.comboBox_PredictMark.DataSource = paramsNames;
            predictMarkControl0.comboBox_PredictMark.SelectedIndex = predictMarkControl0.comboBox_PredictMark.Items.Count - 1;
            predictMarkControl0.textBox_PredictMarkName.Text = "Класс " + predictMarkControl0.comboBox_PredictMark.GetItemText(predictMarkControl0.comboBox_PredictMark.SelectedItem);
            button_Next.Visible = true;         
        }

        public void UpdateAllComboBoxPredictMark()
        {
            foreach (PredictMarkControl control in Controls.OfType<PredictMarkControl>())
            {
                var paramsNames = LearningData.ParamNamesInput.Concat(LearningData.ParamNamesOutput).ToList();
                control.comboBox_PredictMark.DataSource = paramsNames;
                var index = paramsNames.Count - LearningData.ParamNamesOutput.Count + control.MarkIndex;
                control.comboBox_PredictMark.SelectedIndex = index;
            }

            label_DataPreviewInfo.Text = $"Всего {LearningData.ParamNamesInput.Count + LearningData.ParamNamesOutput.Count} параметров";
            label_DataPreviewInfo.Text += $" и {LearningData.LearningExamples.Count} пример(ов)    ";
            var stringBuilder = new StringBuilder();
            foreach (var pair in LearningData.ClassesCount)
            {
                stringBuilder.Append($"{pair.Key} - {pair.Value}    ");
            }
            label_DataPreviewInfo.Text += stringBuilder.ToString();
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (panel_FromFile.Visible == true && checkBox_FromFileSaveCheck.Checked == true)
            {
                if (Connection.Db.Value.Datasets.Where(item => item.Owner == null).Any(item => item.Name == textBox_FromFileSaveName.Text))
                {
                    if (MessageBox.Show("В базе данных уже есть набор данных с таким названием. Продолжить?", "Наименование уже существует", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        while (Connection.Db.Value.Datasets.Where(item => item.Owner == null).Any(item => item.Name == textBox_FromFileSaveName.Text))
                        {
                            textBox_FromFileSaveName.Text = textBox_FromFileSaveName.Text + "0";
                        }
                        var dataset = LearningData.ConvertToDotNetDataSet();
                        CreateTableInLocalDatabase(dataset);
                    }
                }
                else
                {
                    var dataset = LearningData.ConvertToDotNetDataSet();
                    CreateTableInLocalDatabase(dataset);
                }
            }

            GlobalTemplate.LearningData = LearningData;
            var parent = this.ParentForm as MainForm;
            parent.button_Configuration.Enabled = true;
            parent.RecolorButtons(parent.button_Configuration);
            parent.button_Configuration_Click(sender, e);
        }

        private void CreateTableInLocalDatabase(DataSet dataSet)
        {
            //для начала нам нужно определить имя таблицы в базе данных
            //мы получаем список всех датасетов из бд по их id_Table и к последнему нужно добавить +1
            int lastId;
            try
            {
                lastId = Connection.Db.Value.Datasets.OrderByDescending(item => item.ID_Table).First().ID_Table;
                lastId += 1;
            }
            catch
            {
                lastId = 1;
            }
            

            //теперь нужно создать запрос на создание таблицы под наш датасет в базе
            StringBuilder createQuery = new StringBuilder($"CREATE TABLE [ДинамическаяЧасть_ПользовательскиеДатасеты].[{lastId}]");
            createQuery.Append("(");
            for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
            {
                createQuery.Append($"[{dataSet.Tables[0].Columns[i].ColumnName}]");
                createQuery.Append(" ");
                createQuery.Append("float");
                createQuery.Append(",");
            }
            createQuery.Append(")");

            //теперь нужно создать таблицу под наш датасет в базе
            using (SqlConnection sqlConnection = new SqlConnection(LocalSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                //создаем таблицу в бд
                SqlCommand sqlCommandCreateTable = new SqlCommand(createQuery.ToString(), sqlConnection);
                sqlCommandCreateTable.Transaction = sqlTransaction;
                sqlCommandCreateTable.ExecuteNonQuery();

                //вставляем данные
                SqlCommand sqlCommandInsertIntoTable = new SqlCommand($"SELECT * FROM [ДинамическаяЧасть_ПользовательскиеДатасеты].[{lastId}]", sqlConnection);
                sqlCommandInsertIntoTable.Transaction = sqlTransaction;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandInsertIntoTable);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Update(dataSet, "Table1");

                //и прям обязательно нужно создать запись в Datasets
                Nullable<int> owner = GlobalTemplate.CurrentUser?.ID;
                SqlCommand sqlCommandInsertIntoDatasets = new SqlCommand("INSERT INTO Datasets Values (@Owner, @ID_Table, @Name, @CreationDate, @DeleteDate)", sqlConnection);
                sqlCommandInsertIntoDatasets.Transaction = sqlTransaction;

                SqlParameter ownerParam;
                SqlParameter idTableParam = new SqlParameter("@ID_Table", lastId);
                SqlParameter nameParam = new SqlParameter("@Name", textBox_FromFileSaveName.Text);
                SqlParameter creationDateParam = new SqlParameter("@CreationDate", DateTime.Today);
                SqlParameter deleteDateParam;
                if (owner == null)
                {
                    ownerParam = new SqlParameter("@Owner", DBNull.Value);
                    deleteDateParam = new SqlParameter("@DeleteDate", DateTime.Today.AddDays(5));
                }
                else
                {
                    ownerParam = new SqlParameter("@Owner", owner);
                    deleteDateParam = new SqlParameter("@DeleteDate", DBNull.Value);
                }
                sqlCommandInsertIntoDatasets.Parameters.AddRange( new SqlParameter[] { ownerParam, idTableParam, nameParam, creationDateParam, deleteDateParam } );
                sqlCommandInsertIntoDatasets.ExecuteNonQuery();

                sqlTransaction.Commit();
            }        
        }
        #endregion
    }
}
