using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTools
{
    public class ArithmeticExpressions
    {
        public static double Expression1 (double x, double a)
        {
            double y = 0;
            double x2 = x * x;
            y = Math.Log(Math.Sqrt(x2 + 1 / Math.Tan(a)));
            return y;
        }
    }
}
