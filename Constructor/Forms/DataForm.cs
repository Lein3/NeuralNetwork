using System;
using System.Collections.Generic;
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
        private Point ActivePanelLocation { get; set; } = new Point(300, 150);
        private char FileSeparator { get; set; } = ';';
        LearningData learningData2;
        public DataForm()
        {
            InitializeComponent();
            panel_FromFile.Location = ActivePanelLocation;
            panel_FromDatabase.Location = ActivePanelLocation;
            panel_FromDataset.Location = ActivePanelLocation;
            // в конструкторе панели расположены в целях удобства редактирования тут мы их перемещаем на рабочее место
            //TODO: сделать рабочей кнопку мои наборы данных
            if (GlobalTemplate.CurrentUser != null)
                radioButton4.Enabled = true;
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
            openFileDialog.ShowDialog();
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
                else if (firstLine.Contains('-'))
                {
                    radioButton_Separator2.Checked = true;
                }
            }
            LearningData learningData = new LearningData(openFileDialog.FileName, FileSeparator);          
            dataGridView.DataSource = learningData.ConvertToDotNetDataSet().Tables["Table1"];
            learningData2 = learningData;
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
            DataConnectionDialog.Show(d);
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(d.ConnectionString);
            label_DataSourceName.Text = sqlConnectionStringBuilder.InitialCatalog;
            comboBox_SelectTableFromDataSource.DataSource = GetDatasetsFromDataSource(sqlConnectionStringBuilder);
        }

        private List<string> GetDatasetsFromDataSource(SqlConnectionStringBuilder sqlConnectionStringBuilder)
        {
            using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT name FROM sys.tables", sqlConnection);
                var SelectedTables = sqlCommand.ExecuteReader();
                var TableNames = new List<String>();
                while (SelectedTables.Read())
                {
                    TableNames.Add(SelectedTables.GetString(0));
                }
                return TableNames;
            }
        }
        #endregion

        #region Все Анонимные Датасеты
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromDataset.Visible = true;
            comboBox_SelectLocalDataset.DataSource = GetAllLocalDatasets();
        }

        private List<string> GetAllLocalDatasets()
        {
            var TableNames = new NeuralNetworkConstructorEntities().Database.SqlQuery<string>("SELECT name FROM sys.tables ").ToList();
            TableNames.RemoveRange(TableNames.Count - 9, 9); //в базе 8 таблиц наших и 1 sysdyagrams они в списке находятся в самом конце и мы их оттуда удаляем
            return TableNames;
        }
        #endregion

        #region Мои Датасеты
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            panel_FromDataset.Visible = true;
            comboBox_SelectLocalDataset.DataSource = GetMyDatasets();
        }

        private List<string> GetMyDatasets()
        {
            var TableNames = new NeuralNetworkConstructorEntities().Database.SqlQuery<string>($"SELECT Name From Datasets where Owner = {GlobalTemplate.CurrentUser.ID}").ToList();
            return TableNames;
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
    }
}
