using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class ClassGet
    {
        public static double f(double x)
        {
            double func;
            func = Math.Cos(x) - Math.Sin(2*x);
            return func;
        }

        public static int min(double a, double b)
        {
            if (f(a) < f(b)) return 1;
            else if (f(a) == f(b)) return 0;
            else return 2;
        }
    }
}
