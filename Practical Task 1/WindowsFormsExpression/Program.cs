using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExpression
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool start, stop = false;

            int taskNum = 1;
            string devName = "Вартанов Павел";
            string devYear = "2";
            string devGroup = "09-411";
            string setting = "Релизовать диалоговое взаимодействие для вычисления функции с заданными значениями, построенное на основе конструкционных схем ДВ \"START\" и \"END\"";

            string info = "Выполняется Задание №" + taskNum + ".\nРазработчик: " + devName + ", " + devYear + " курс, группа " + devGroup + ".\nПостановка: " + setting;
            string infoCaption = "Приветствие";
            string startMessage = "Начать работу?";
            string startCaption = "Начать работу?";
            string endMessage = "Закончить работу?";
            string endCaption = "Закончить работу?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultStart, resultEnd;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBox.Show(info, infoCaption);
            while (!stop)
            {
                resultStart = MessageBox.Show(startMessage, startCaption, buttons, MessageBoxIcon.Question);
                start = resultStart == DialogResult.Yes;
                while (start)
                {
                    Application.Run(new MainForm());
                    start = false;
                }
                resultEnd = MessageBox.Show(endMessage, endCaption, buttons, MessageBoxIcon.Question);
                stop = resultEnd == DialogResult.Yes;
            }
            MessageBox.Show("Программа выполнила Задание №" + taskNum + ".", "Информация");
        }
    }
}
