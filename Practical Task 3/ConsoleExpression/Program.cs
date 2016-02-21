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
        static int ChooseGroup()
        {
            int output = 1;
            bool loop;

            Console.WriteLine("Какую из представленных групп функций выполнять?");
            Console.WriteLine("1. Бинарные функции");
            Console.WriteLine("2. Тернарные функции");
            string input = Console.ReadLine();

            loop = true;
            while (loop)
            {
                switch (input)
                {
                    case "1":
                        loop = false;
                        break;
                    case "2":
                        output = 2;
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
        delegate void Calculator(int i);
        static void CalcBinaryExpression(int i)
        {
            double x, a = 0;
            try
            {
                Console.Write("Введите x: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Ответ: " + MyTools.ArithmeticExpressions.binaryExpressions[i-1](x, a));
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Введено не число, повторите ввод.");
                Console.WriteLine();
            }
        }
        static void CalcTernaryExpression(int i)
        {
            double x, y, a = 0;
            try
            {
                Console.Write("Введите x: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите y: ");
                y = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Ответ: " + MyTools.ArithmeticExpressions.ternaryExpressions[i - 1](x, y, a));
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Введено не число, повторите ввод.");
                Console.WriteLine();
            }
        }
        static void Calculate()
        {
            string startMessage = "Начать работу?";
            string endMessage = "Закончить работу?";

            int number;

            bool start, stop = false, calculateGroup, calculateNext = true;
            int counter = 1;
            do
            {
                start = ReadBool(startMessage);
                Console.Clear();
                if (start)
                {
                    number = ChooseGroup();
                    Console.Clear();
                    Calculator CalcExpression;
                    if (number == 1)
                        CalcExpression = CalcBinaryExpression;
                    else
                        CalcExpression = CalcTernaryExpression;
                    calculateGroup = ReadBool("Вычислить значения функций группы №" + number + "?");
                    Console.Clear();
                    if (calculateGroup)
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
                        } while (counter <= 3 && calculateNext);
                    }
                    start = false;
                }
                stop = ReadBool(endMessage);
                Console.Clear();
            } while (!stop);
        }
        static void Main(string[] args)
        {
            int taskNum = 3;
            string devName = "Вартанов Павел";
            string devYear = "2";
            string devGroup = "09-411";
            string settingInfo = "Реализовать диалоговое взаимодействие для альтернативного вычислениядвух групп функций, построенное на основе конструкционной схемы ДВ \"if-then-\nelse\".";

            string task = "Выполняется Задание №" + taskNum + ".";
            string developer = "Разработчик: " + devName + ", " + devYear + " курс, группа " + devGroup + ".";
            string setting = "Постановка: " + settingInfo;

            Console.WriteLine(task);
            Console.WriteLine(developer);
            Console.WriteLine(setting);
            Console.WriteLine();

            Calculate();

            Console.WriteLine("Программа выполнила Задание №" + taskNum + ".");
            Console.ReadLine();
        }
    }
}
