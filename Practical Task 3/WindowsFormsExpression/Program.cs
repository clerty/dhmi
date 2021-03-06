﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExpression
{
    static class Program
    {
        static string groupMessage(int i)
        {
            return "Вычислить значения функций группы №" + i + "?";
        }
        static string groupCaption(int i)
        {
            return "Вычислить значения функций группы №" + i + "?";
        }
        static string nextMessage(int i)
        {
            return "Вычислить значение функции №" + i + "?";
        }
        static string nextCaption(int i)
        {
            return "Вычислить значение функции №" + i + "?";
        }

        static void Calculate()
        {
            string startMessage = "Начать работу?";
            string startCaption = "Начать работу?";
            string endMessage = "Закончить работу?";
            string endCaption = "Закончить работу?";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult resultStart, resultGroup, resultEnd;

            bool start, stop = false, calculateGroup, calculatenext = true;
            Form mainform = new Form();
            ChooseGroupForm chooseGroupForm;
            int counter = 1;
            int number = 0;

            while (!stop)
            {
                resultStart = MessageBox.Show(startMessage, startCaption, buttons, MessageBoxIcon.Question);
                start = resultStart == DialogResult.Yes;
                if (start)
                {
                    chooseGroupForm = new ChooseGroupForm();
                    do
                    {
                        chooseGroupForm.ShowDialog();
                        number = chooseGroupForm.i;
                        switch (number)
                        {
                            case 1:
                            case 2:
                                break;
                            default:
                                MessageBox.Show("Ответ не принят, повторите ввод.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Question);
                                break;
                        }
                    } while (number == 0);
                    chooseGroupForm.Close();
                    resultGroup = MessageBox.Show(groupMessage(number), groupCaption(number), buttons, MessageBoxIcon.Question);
                    calculateGroup = resultGroup == DialogResult.Yes;
                    if (calculateGroup)
                    {
                        while (calculatenext & (counter <= 3))
                        {
                            resultStart = MessageBox.Show(nextMessage(counter), nextCaption(counter), buttons, MessageBoxIcon.Question);
                            calculatenext = resultStart == DialogResult.Yes;
                            if (calculatenext)
                            {
                                switch (number)
                                {
                                    case 1:
                                        mainform = new BinaryForm(counter);
                                        break;
                                    case 2:
                                        mainform = new TernaryForm(counter);
                                        break;
                                }
                                mainform.ShowDialog();
                                counter++;
                            }
                        }
                    }
                    start = false;
                }
                resultEnd = MessageBox.Show(endMessage, endCaption, buttons, MessageBoxIcon.Question);
                stop = resultEnd == DialogResult.Yes;
            }
        }
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {

            int taskNum = 3;
            string devName = "Вартанов Павел";
            string devYear = "2";
            string devGroup = "09-411";
            string setting = "Реализовать диалоговое взаимодействие для альтернативного вычисления двух групп функций, построенное на основе конструкционной схемы ДВ \"if-then-else\".";

            string info = "Выполняется Задание №" + taskNum + ".\nРазработчик: " + devName + ", " + devYear + " курс, группа " + devGroup + ".\nПостановка: " + setting;
            string infoCaption = "Приветствие";
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBox.Show(info, infoCaption);

            Calculate();

            MessageBox.Show("Программа выполнила Задание №" + taskNum + ".", "Информация");
        }
    }
}
