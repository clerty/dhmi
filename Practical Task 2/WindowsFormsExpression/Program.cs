using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExpression
{
    static class Program
    {
        static string nextMessage(int i)
        {
            return "Вычислить значение функции №" + i + "?";
        }

        static string nextCaption(int i)
        {
            return "Вычислить значение функции №" + i + "?";
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int counter = 1;

            int taskNum = 2;
            string devName = "Вартанов Павел";
            string devYear = "2";
            string devGroup = "09-411";
            string setting = "Реализовать диалоговое взаимодействие для поледовательного вычисления нескольких функций, построенное на основе конструкционной схемы ДВ \"Последовательная интерпретация элементов\".";

            string info = "Выполняется Задание №" + taskNum + ".\nРазработчик: " + devName + ", " + devYear + " курс, группа " + devGroup + ".\nПостановка: " + setting;
            string infoCaption = "Приветствие";
            string startMessage = "Начать работу?";
            string startCaption = "Начать работу?";
            string endMessage = "Закончить работу?";
            string endCaption = "Закончить работу?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultStart, resultEnd;

            bool start, stop = false, calculatenext = true;
            Form mainform;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBox.Show(info, infoCaption);
            while (!stop)
            {
                resultStart = MessageBox.Show(startMessage, startCaption, buttons, MessageBoxIcon.Question);
                start = resultStart == DialogResult.Yes;
                if (start)
                {
                    while (calculatenext & (counter <= 3))
                    {
                        resultStart = MessageBox.Show(nextMessage(counter), nextCaption(counter), buttons, MessageBoxIcon.Question);
                        calculatenext = resultStart == DialogResult.Yes;
                        if (calculatenext)
                        {
                            mainform = new MainForm(counter);
                            mainform.ShowDialog();
                            counter++;
                        }
                    }
                    start = false;
                }
                resultEnd = MessageBox.Show(endMessage, endCaption, buttons, MessageBoxIcon.Question);
                stop = resultEnd == DialogResult.Yes;
            }
            MessageBox.Show("Программа выполнила Задание №" + taskNum + ".", "Информация");
        }
    }
}
