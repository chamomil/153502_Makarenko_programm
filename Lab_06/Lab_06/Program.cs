using System;

namespace Lab_06
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Car car = new Toyota();
            Console.WriteLine(car.Met());
            Toyota toyota = (Toyota)car;
            Console.WriteLine(toyota.Met());

            Console.WriteLine("Toyota: " + toyota.GetBrand());
            Console.WriteLine(toyota.GetColour());

            BMW bmw = new BMW();
            Console.WriteLine("BMW: " + bmw.GetBrand());
            Console.WriteLine(bmw.GetColour());
        }
    }
}