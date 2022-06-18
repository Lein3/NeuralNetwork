﻿using System;
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

            //TODO: сделать возврат на стартовый экран
            //TODO: сделать имя модели
            //TODO: автоматизированный режим
            //TODO: загрузить модель
            //TODO: мои модели
            //TODO: мои наборы данных
            //TODO: запись моделей в базу данных
            //TODO: асинхронное обучение
            //TODO: открытие формочки структуры с готовой
            //TODO: случайная генерация примеров
            //TODO: сохранение модели как сериализация
            //TODO: служба для чистки базы данных
        }
    }
}
