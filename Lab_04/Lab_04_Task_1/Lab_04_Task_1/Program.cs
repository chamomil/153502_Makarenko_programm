using System;
//using Lab_04_Task_1;

namespace Lab_04_Task_1
{
    public class Lab_04
    {
        public static bool checkUp(string input)
        {
            if (!int.TryParse(input, out int result))
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
            Console.Write("Enter the name of airport : ");
            string inp = Console.ReadLine();
            Console.Write("Enter the amount of seats on a plane : ");
            string inp2 = Console.ReadLine();
            while (!checkUp(inp2))
            {
                Console.Write("Enter the amount of seats on a plane : ");
                inp2 = Console.ReadLine();
            }
            int seats = int.Parse(inp2);
            Console.Write("Enter the amount of seats, which were sold : ");
            string inp3 = Console.ReadLine();
            while (!checkUp(inp3))
            {
                Console.Write("Enter the amount of seats, which were sold : ");
                inp3 = Console.ReadLine();
            }
            int sold = int.Parse(inp3);
            Console.Write("Enter the price of a ticket : ");
            string inp4 = Console.ReadLine();
            while (!checkUp(inp4))
            {
                Console.Write("Enter the price of a ticket : ");
                inp4 = Console.ReadLine();
            }
            int pric = int.Parse(inp4);
            Airport airport = Airport.Creating(inp, seats, sold, pric);

            Console.WriteLine("The amount of money from sold tickets: " + airport.Sold_Seats());
            Console.Write("Enter the number by which you want to reduce the ticket price : ");
            string input = Console.ReadLine();
            int tmp = int.Parse(input);
            airport.Decrease_price(tmp);
            Console.WriteLine("The amount of money from sold tickets: " + airport.Sold_Seats());
            Console.Write("Enter the number by which you want to increase the ticket price : ");
            input = Console.ReadLine();
            tmp = int.Parse(input);
            airport.Increase_price(tmp);
            Console.WriteLine("The amount of money from sold tickets: " + airport.Sold_Seats());
        }
    }
}