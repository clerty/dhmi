using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public static class ArithmeticExpressions
    {
        public delegate double BinaryFunction(double x, double a);
        public static BinaryFunction[] binaryExpressions = new BinaryFunction[3] { BinaryExpression1, BinaryExpression2, BinaryExpression3 };
        public static double BinaryExpression1(double x, double a)
        {
            double y = 0;
            double x2 = x * x;
            y = Math.Log(Math.Sqrt(x2 + 1 / Math.Tan(a)));
            return y;
        }
        public static double BinaryExpression2(double x, double a)
        {
            double y = 0;
            double x2 = x * x;
            y = Math.Sin(x2) / Math.Log(Math.Abs(a+x));
            return y;
        }
        public static double BinaryExpression3(double x, double a)
        {
            double y = 0;
            y = Math.Log(Math.Abs(x+1)) + Math.Sqrt(x-a);
            return y;
        }
        public delegate double TernaryFunction(double x, double y, double a);
        public static TernaryFunction[] ternaryExpressions = new TernaryFunction[3] { TernaryExpression1, TernaryExpression2, TernaryExpression3 };
        public static double TernaryExpression1(double x, double y, double a)
        {
            double z = 0;
            y = Math.Sin(x)/(y + Math.Pow(Math.E, a));
            return z;
        }
        public static double TernaryExpression2(double x, double y, double a)
        {
            double z = 0;
            y = (Math.Sqrt(a) + y)/(1 + Math.Pow(Math.E, x));
            return z;
        }
        public static double TernaryExpression3(double x, double y, double a)
        {
            double z = 0;
            y = Math.Tan(x + a) + Math.Log(Math.Abs(y - 1));
            return z;
        }
    }
}
