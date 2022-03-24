using System;
using Task_01;

namespace Task1N
{
    public class Task1
    {
        public static bool checkUp(string input)
        {
            if (!double.TryParse(input, out double result))
            {
                Console.WriteLine("invalid value, try again");
                return false;
            }
            else
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            /*double a = 2;
            double b = 3;
            double x = 1*/
            double x, a, b;
            Console.Write("Enter: x = ");
            string inp = Console.ReadLine();
            while (!checkUp(inp))
            {
                Console.Write("x = ");
                inp = Console.ReadLine();
            }
            x = double.Parse(inp);
            Console.WriteLine("f(x) == " + ClassGet.f(x));

            Console.Write("Enter: a = ");
            inp = Console.ReadLine();
            while (!checkUp(inp))
            {
                Console.Write("a = ");
                inp = Console.ReadLine();
            }
            a = double.Parse(inp);
            Console.Write("\tb = ");
            string inp2 = Console.ReadLine();
            while (!checkUp(inp2))
            {
                Console.Write("b = ");
                inp2 = Console.ReadLine();
            }
            b = double.Parse(inp2);
            if (ClassGet.min(a, b) == 1) Console.WriteLine("f(a) is smaller");
            else if (ClassGet.min(a, b) == 0) Console.WriteLine("f(a) and f(b) are equal");
            else Console.WriteLine("f(b) is smaller");
        }
    }
}