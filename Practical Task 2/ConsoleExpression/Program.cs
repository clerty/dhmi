using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExpression
{
    class Program
    {        
        static bool ReadBool(string S)
        {
            bool output, loop;
            output = false;

            Console.WriteLine(S);
            string input = Console.ReadLine();

            loop = true;
            while (loop)
            {
                switch (input)
                {
                    case "Да":
                    case "да":
                        output = true;
                        loop = false;
                        break;
                    case "Нет":
                    case "нет":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Ответ не принят, повторите ввод.");
                        input = Console.ReadLine();
                        break;
                }
            }

            return output;
        }

        static void CalcExpression(int i)
        {
            double x, a = 0;

            try
            {
                Console.Write("Введите x: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Ответ: " + MyTools.ArithmeticExpressions.expression[i-1](x, a));
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Введено не число, повторите ввод.");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int taskNum = 2;
            string devName = "Вартанов Павел";
            string devYear = "2";
            string devGroup = "09-411";
            string settingInfo = "Реализовать диалоговое взаимодействие для поледовательного\nвычисления нескольких функций, построенное на основе конструкционной схемы ДВ\n\"Последовательная интерпретация элементов\".";

            string startMessage = "Начать работу?";
            string endMessage = "Закончить работу?";

            string task = "Выполняется Задание №" + taskNum + ".";
            string developer = "Разработчик: " + devName + ", " + devYear + " курс, группа " + devGroup + ".";
            string setting = "Постановка: " + settingInfo;

            bool start, stop = false, calculateNext = true;
            int counter = 1;

            Console.WriteLine(task);
            Console.WriteLine(developer);
            Console.WriteLine(setting);
            Console.WriteLine();

            while (!stop)
            {
                start = ReadBool(startMessage);
                Console.Clear();
                if (start)
                {
                    do
                    {
                        calculateNext = ReadBool("Вычислить значение функции №" + counter + "?");
                        Console.Clear();
                        if (calculateNext)
                        {
                            CalcExpression(counter);
                            counter++;
                        }
                    } while (calculateNext & (counter <= 3));
                    start = false;
                }
                stop = ReadBool(endMessage);
                Console.Clear();
            }

            Console.WriteLine("Программа выполнила Задание №" + taskNum + ".");
            Console.ReadLine();
        }
    }
}
