using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public static class ArithmeticExpressions
    {
        public delegate double MyDelegate(double x, double a);

        public static MyDelegate[] expression = new MyDelegate[3] { Expression1, Expression2, Expression3 };

        public static double Expression1(double x, double a)
        {
            double y = 0;
            double x2 = x * x;
            y = Math.Log(Math.Sqrt(x2 + 1 / Math.Tan(a)));
            return y;
        }

        public static double Expression2(double x, double a)
        {
            double y = 0;
            double x2 = x * x;
            y = Math.Sin(x2) / Math.Log(Math.Abs(a+x));
            return y;
        }

        public static double Expression3(double x, double a)
        {
            double y = 0;
            y = Math.Log(Math.Abs(x+1)) + Math.Sqrt(x-a);
            return y;
        }
    }
}
