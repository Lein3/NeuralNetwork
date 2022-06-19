using System;
using System.Data.SqlClient;
using System.IO;
using System.ServiceProcess;

namespace DatabaseCleaner
{
    partial class DatabaseCleaner : ServiceBase
    {
        private NeuralNetworkConstructorEntities db { get; set; } = new NeuralNetworkConstructorEntities();
        public DatabaseCleaner()
        {
            InitializeComponent();
        }

        protected async override void OnStart(string[] args)
        {
            System.Timers.Timer timer = new System.Timers.Timer() { Interval = 1800000 };
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (DateTime.Now.Hour == 8)
            {
                RemoveTables();
            }
        }
        
        private void RemoveTables()
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(db.Database.Connection.ConnectionString))
                {
                    sqlConnection.Open();
                    foreach (var dataset in db.Datasets)
                    {
                        if (DateTime.Now > dataset.DeleteDate)
                        {
                            SqlCommand sqlCommand = new SqlCommand($"DROP TABLE [ДинамическаяЧасть_ПользовательскиеДатасеты].[{dataset.ID_Table}]", sqlConnection);
                            sqlCommand.ExecuteNonQueryAsync();
                            db.Datasets.Remove(dataset);
                        }
                    }
                    db.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                File.WriteAllText(@"C:\Users\Durka\Desktop\лог очистки базы.txt", e.Message);
            }
        }
    }
}
