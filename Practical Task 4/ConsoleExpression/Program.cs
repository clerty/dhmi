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
        static void Greet()
        {
            int taskNum = 4;
            string devName = "Вартанов Павел";
            string devYear = "2";
            string devGroup = "09-411";
            string settingInfo = "";

            string task = "Выполняется Задание №" + taskNum + ".";
            string developer = "Разработчик: " + devName + ", " + devYear + " курс, группа " + devGroup + ".";
            string setting = "Постановка: " + settingInfo;

            Console.WriteLine(task);
            Console.WriteLine(developer);
            Console.WriteLine(setting);
            Console.WriteLine();
        }
        static void Part()
        {
            int taskNum = 4;
            Console.WriteLine("Программа выполнила Задание №" + taskNum + ".");
            Console.ReadLine();
        }
        static void Calculate()
        {
            bool calculate = ReadBool("Вычислить значение функции?");
            if (calculate)
            {
                double x = 0, a = 0;
                try
                {
                    Console.Write("Введите x: ");
                    x = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите a: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();

                    Console.WriteLine("Ответ: " + MyTools.ArithmeticExpressions.Expression1(x, a));
                    Console.WriteLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine();
                    Console.WriteLine("Введено не число, повторите ввод.");
                    Console.WriteLine();
                }
            }            
        }
        static void CalculateSeveralTimes()
        {
            string startMessage = "Начать работу?";
            string endMessage = "Закончить работу?";

            int counter = 0;

            bool start, stop = false;
            do
            {
                start = ReadBool(startMessage);
                Console.Clear();
                if (start)
                {
                    Console.WriteLine("Сколько раз выполнить функцию?");
                    counter = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < counter; i++)
                    {
                        Calculate();
                    }
                }
                stop = ReadBool(endMessage);
                Console.Clear();
            } while (!stop);
        }
        static void Main(string[] args)
        {
            Greet();
            CalculateSeveralTimes();
            Part();
        }
    }
}
