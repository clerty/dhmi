using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExpression
{
    static class Program
    {
        static void Greet()
        {
            int taskNum = 4;
            string devName = "Вартанов Павел";
            string devYear = "2";
            string devGroup = "09-411";
            string setting = "";

            string info = "Выполняется Задание №" + taskNum + ".\nРазработчик: " + devName + ", " + devYear + " курс, группа " + devGroup + ".\nПостановка: " + setting;
            string infoCaption = "Приветствие";

            MessageBox.Show(info, infoCaption);
        }
        static void Part()
        {
            int taskNum = 4;
            MessageBox.Show("Программа выполнила Задание №" + taskNum + ".", "Информация");
        }
        static void CalculateSeveralTimes()
        {
            string startMessage = "Начать работу?";
            string startCaption = "Начать работу?";
            string endMessage = "Закончить работу?";
            string endCaption = "Закончить работу?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultStart, resultEnd;

            bool start, stop = false;
            Form mainform = new Form();
            int counter = 4;
            List<Form> forms = new List<Form>();
            do
            {
                resultStart = MessageBox.Show(startMessage, startCaption, buttons, MessageBoxIcon.Question);
                start = resultStart == DialogResult.Yes;
                if (start)
                {
                    for (int i = 0; i < counter; i++)
                    {
                        forms.Add(new MainForm());
                    }
                    Application.Run(new MultiFormContext(forms.ToArray<Form>()));
                }
                resultEnd = MessageBox.Show(endMessage, endCaption, buttons, MessageBoxIcon.Question);
                stop = resultEnd == DialogResult.Yes;
            } while (!stop);
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Greet();
            CalculateSeveralTimes();
            Part();
        }
    }
}
