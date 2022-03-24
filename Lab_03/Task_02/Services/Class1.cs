using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02.Services
{
    public class ClassGet
    { 
        public static double Func(double z)
        {
            double x, y;
            if (z < 1.0) {
                Console.WriteLine("Branch #1");
                x = Math.Pow(z, 3) + 0.2;
            }
            else {
                Console.WriteLine("Branch #2");
                x = z + Math.Log(z);
            }
            double x3 = Math.Pow(x, 3);
            y = Math.Pow(Math.Cos(x3), 3) + Math.Pow(Math.Sin(x3), 2);
            return y;
        }
    }
}
