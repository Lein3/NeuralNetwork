using System.ServiceProcess;

namespace DatabaseCleaner
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new DatabaseCleaner()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
