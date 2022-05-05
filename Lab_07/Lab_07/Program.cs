using System;

namespace Lab_07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Equation first = new Equation(1, -4, 4);
            Equation second = new Equation(1, 1, -20);
            Equation third = new Equation(0, 5, -10);
            Console.WriteLine(first[1]); //2
            Console.WriteLine(second[2]); //-20

            first.Find(); // 2

            second = second + 1;
            Console.WriteLine(second[2]);//-19
            second = second - 1;
            Console.WriteLine(second[2]);//-20
            ++third;
            Console.WriteLine(third[1]); // 6
            --third;
            Console.WriteLine(third[1]); // 5

            first = first * 2;
            Console.WriteLine(first[1]); //-8
            first = first / 2;
            Console.WriteLine(first[1]); //-4

            if (first != third) Console.WriteLine("not equal");
            Equation forth = new Equation(1, -4, 4);
            if (first == forth) Console.WriteLine("equal");

            if (first) Console.WriteLine("there are roots");
            Equation fifth = new Equation(0, 0, 4);
            if (fifth) { }
            else Console.WriteLine("no roots");

            int k = (int)first + 10;
            Console.WriteLine(k);
            fifth = (Equation)k;
            Console.WriteLine(fifth[0]);

            Console.WriteLine(first.ToString());
        }
    }
}