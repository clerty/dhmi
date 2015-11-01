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
                        output = true;
                        loop = false;
                        break;
                    case "да":
                        output = true;
                        loop = false;
                        break;
                    case "Нет":
                        loop = false;
                        break;
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

        static void Main(string[] args)
        {
            bool start, stop = false;
            double x, a = 0;

            int taskNum = 1;
            string devName = "Вартанов Павел";
            string devYear = "2";
            string devGroup = "09-411";
            string settingInfo = "Релизовать диалоговое взаимодействие для вычисления функции\nс заданными значениями, построенное на основе конструкционных схем ДВ \"START\" и \"END\"";

            string startMessage = "Начать работу?";
            string endMessage = "Закончить работу?";

            string task = "Выполняется Задание №" + taskNum + ".";
            string developer = "Разработчик: " + devName + ", " + devYear + " курс, группа " + devGroup + ".";
            string setting = "Постановка: " + settingInfo;

            Console.WriteLine(task);
            Console.WriteLine(developer);
            Console.WriteLine(setting);
            Console.WriteLine();

            while (!stop)
            {
                start = ReadBool(startMessage);
                Console.Clear();
                while (start)
                {
                    try
                    {
                        Console.Write("Введите x: ");
                        x = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Введите a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("Ответ: " + MyTools.ArithmeticExpressions.Expression1(x, a));
                        Console.WriteLine();

                        start = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Введено не число, повторите ввод.");
                        Console.WriteLine();
                    }
                }
                stop = ReadBool(endMessage);
                Console.Clear();
            }

            Console.WriteLine("Программа выполнила Задание №1.");
            Console.ReadLine();
        }
    }
}
