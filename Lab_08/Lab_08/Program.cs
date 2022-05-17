using System;

namespace Lab_08
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Airport airport = new Airport();
            airport.AddTariffWithoutDisco("Japan", 150.0);
            airport.AddTariffWithDiscount("China", 50.0);
            string max = airport.MaxPrice();
            Console.WriteLine(max);
        }
    }
}