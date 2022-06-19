using System;
using System.Windows.Forms;

namespace Constructor
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
            Application.Run(new MainForm());

            //TODO: мои модели
            //TODO: запись моделей в базу данных
            //TODO: автоматизированный режим
        }
    }
}
