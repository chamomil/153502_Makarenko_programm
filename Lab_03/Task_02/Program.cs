using System;
using Task_02.Services;

namespace task2
{
    public class Task2
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
            Console.Write("Enter z :");
            string inp = Console.ReadLine();
            while (!checkUp(inp))
            {
                Console.Write("z = ");
                inp = Console.ReadLine();
            }
            double z = double.Parse(inp);
            double y = ClassGet.Func(z);
            Console.WriteLine("y = " + y);
        }
    }
}