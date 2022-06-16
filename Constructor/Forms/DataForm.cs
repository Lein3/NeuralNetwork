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
        public LearningData learningData { get; set; }
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
            textBox_FromFileSaveName.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            predictMarkControl.Visible = true;
            UpdateComboBoxPredictMark();
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

            dynamicSqlConnectionStringBuilder = new SqlConnectionStringBuilder(d.ConnectionString);
            label_DataSourceName.Text = dynamicSqlConnectionStringBuilder.InitialCatalog;
            comboBox_SelectDatasetFromDataSource.DataSource = GetDatasetsFromDataSource();
        }

        private List<string> GetDatasetsFromDataSource()
        {
            using (SqlConnection sqlConnection = new SqlConnection(dynamicSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbo' AND TABLE_NAME != 'sysdiagrams'", sqlConnection);
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
                try
                {
                    learningData = new LearningData(dataSet);
                    predictMarkControl.Visible = true;
                    UpdateComboBoxPredictMark();
                }
                catch (Exception)
                {
                    predictMarkControl.comboBox_PredictMark.DataSource = null;
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

        private IQueryable<Datasets> GetDatasetsFromLocalDatabase(Nullable<int> id_Owner)
        {
            var Datasets = Connection.db.Value.Datasets.Where(item => item.Owner == id_Owner).OrderBy(item => item.Name);
            return Datasets;
        }

        private void comboBox_SelectDatasetFromLocalDatabase_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var tableName = (sender as ComboBox).SelectedValue.ToString();        
            using (SqlConnection sqlConnection = new SqlConnection(localSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM [ДинамическаяЧасть_ПользовательскиеДатасеты].[{tableName}]", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataSet dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet);
                dataGridView.DataSource = null;
                dataGridView.DataSource = dataSet.Tables[0];
                learningData = new LearningData(dataSet);
                predictMarkControl.Visible = true;
                UpdateComboBoxPredictMark();
            }
        }
        #endregion

        #region Остальное
        private void SetAllPanelsInvisible()
        {
            foreach (var panel in this.Controls.OfType<Panel>())
                panel.Visible = false;
        }

        public void UpdateComboBoxPredictMark()
        {
            label_DataPreviewInfo.Text = $"Всего {learningData.ParamNamesInput.Count + learningData.ParamNamesOutput.Count} параметров";
            label_DataPreviewInfo.Text += $" и {learningData.LearningExamples.Count} пример(ов)";

            var paramsNames = learningData.ParamNamesInput.Concat(learningData.ParamNamesOutput).ToList();
            predictMarkControl.comboBox_PredictMark.DataSource = paramsNames;
            predictMarkControl.comboBox_PredictMark.SelectedIndex = predictMarkControl.comboBox_PredictMark.Items.Count - 1;
            button_Next.Visible = true;         
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            if (panel_FromFile.Visible == true && checkBox_FromFileSaveCheck.Checked == true)
            {
                if (Connection.db.Value.Datasets.Where(item => item.Owner == null).Any(item => item.Name == textBox_FromFileSaveName.Text))
                {
                    if (MessageBox.Show("В базе данных уже есть набор данных с таким названием. Продолжить?", "Наименование уже существует", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        while (Connection.db.Value.Datasets.Where(item => item.Owner == null).Any(item => item.Name == textBox_FromFileSaveName.Text))
                        {
                            textBox_FromFileSaveName.Text = textBox_FromFileSaveName.Text + "0";
                        }
                        var dataset = learningData.ConvertToDotNetDataSet();
                        CreateTableInLocalDatabase(dataset);
                    }
                }
                else
                {
                    var dataset = learningData.ConvertToDotNetDataSet();
                    CreateTableInLocalDatabase(dataset);
                }
            }

            GlobalTemplate.LearningData = learningData;
            var parent = this.ParentForm as MainForm;
            parent.button_Configuration.Enabled = true;
            parent.RecolorButtons(parent.button_Configuration);
            parent.button_Configuration_Click(sender, e);
        }

        private void CreateTableInLocalDatabase(DataSet dataSet)
        {
            //для начала нам нужно определить имя таблицы в базе данных
            //мы получаем список всех датасетов из бд по их id_Table и к последнему нужно добавить +1
            var lastID = Connection.db.Value.Datasets.OrderByDescending(item => item.ID_Table).First().ID_Table;
            lastID += 1;

            //теперь нужно создать запрос на создание таблицы под наш датасет в базе
            StringBuilder createQuery = new StringBuilder($"CREATE TABLE [ДинамическаяЧасть_ПользовательскиеДатасеты].[{lastID}]");
            createQuery.Append("(");
            for (int i = 0; i < dataSet.Tables[0].Columns.Count; i++)
            {
                createQuery.Append(dataSet.Tables[0].Columns[i].ColumnName);
                createQuery.Append(" ");
                createQuery.Append("float");
                createQuery.Append(",");
            }
            createQuery.Append(")");

            //теперь нужно создать таблицу под наш датасет в базе
            using (SqlConnection sqlConnection = new SqlConnection(localSqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();

                //создаем таблицу в бд
                SqlCommand sqlCommandCreateTable = new SqlCommand(createQuery.ToString(), sqlConnection);
                sqlCommandCreateTable.Transaction = sqlTransaction;
                sqlCommandCreateTable.ExecuteNonQuery();

                //вставляем данные
                SqlCommand sqlCommandInsertIntoTable = new SqlCommand($"SELECT * FROM [ДинамическаяЧасть_ПользовательскиеДатасеты].[{lastID}]", sqlConnection);
                sqlCommandInsertIntoTable.Transaction = sqlTransaction;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommandInsertIntoTable);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.Update(dataSet, "Table1");

                //и прям обязательно нужно создать запись в Datasets
                Nullable<int> owner = GlobalTemplate.CurrentUser?.ID;
                SqlCommand sqlCommandInsertIntoDatasets = new SqlCommand("INSERT INTO Datasets Values (@Owner, @ID_Table, @Name, @CreationDate, @DeleteDate)", sqlConnection);
                sqlCommandInsertIntoDatasets.Transaction = sqlTransaction;

                SqlParameter ownerParam;
                SqlParameter idTableParam = new SqlParameter("@ID_Table", lastID);
                SqlParameter NameParam = new SqlParameter("@Name", textBox_FromFileSaveName.Text);
                SqlParameter CreationDateParam = new SqlParameter("@CreationDate", DateTime.Today);
                SqlParameter DeleteDateParam;
                if (owner == null)
                {
                    ownerParam = new SqlParameter("@Owner", DBNull.Value);
                    DeleteDateParam = new SqlParameter("@DeleteDate", DateTime.Today.AddDays(5));
                }
                else
                {
                    ownerParam = new SqlParameter("@Owner", owner);
                    DeleteDateParam = new SqlParameter("@DeleteDate", DBNull.Value);
                }
                sqlCommandInsertIntoDatasets.Parameters.AddRange( new SqlParameter[] { ownerParam, idTableParam, NameParam, CreationDateParam, DeleteDateParam } );
                sqlCommandInsertIntoDatasets.ExecuteNonQuery();

                sqlTransaction.Commit();
            }        
        }
        #endregion
    }
}
