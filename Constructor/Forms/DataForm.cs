using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;

namespace Constructor
{
    public partial class DataForm : Form
    {
        private Point ActivePanelLocation = new Point(300, 150);
        public DataForm()
        {
            InitializeComponent();
            panel_FromFile.Location = ActivePanelLocation;
            panel_FromDatabase.Location = ActivePanelLocation;
            panel_FromDataset.Location = ActivePanelLocation;
            // в конструкторе панели расположены в целях удобства редактирования тут мы их перемещаем на рабочее место
            //TODO: сделать рабочей кнопку мои наборы данных
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromFile.Visible = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromDatabase.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            SetAllPanelsInvisible();
            panel_FromDataset.Visible = true;
            comboBox_SelectLocalDataset.DataSource = GetLocalDatasets();
        }

        private void SetAllPanelsInvisible()
        {
            foreach (var panel in this.Controls.OfType<Panel>())
                panel.Visible = false;
        }

        private void button_FromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            textBox_FilePath.Text = openFileDialog.FileName;
            foreach (var line in File.ReadLines(openFileDialog.FileName))
            {
                var array = line.Split();
                dataGridView.Rows.Add(array);
            }
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

        private List<string> GetLocalDatasets()
        {
            var TableNames = new NeuralNetworkConstructorEntities().Database.SqlQuery<string>("SELECT name AS[Название таблицы] FROM sys.tables").ToList();
            TableNames.RemoveRange(TableNames.Count - 9, 9); //в базе 8 таблиц наших и 1 sysdyagrams они в списке находятся в самом конце и мы их оттуда удаляем
            return TableNames;
        }

        private List<string> GetDatasetsFromDataSource(SqlConnectionStringBuilder sqlConnectionStringBuilder)
        {
            using (SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("SELECT name AS [Название таблицы], create_date AS [Дата создания] FROM sys.tables", sqlConnection);
                var SelectedTables = sqlCommand.ExecuteReader();
                var TableNames = new List<String>();
                while (SelectedTables.Read())
                {
                    TableNames.Add(SelectedTables.GetString(0));
                }
                return TableNames;
            }
        }
    }
}
