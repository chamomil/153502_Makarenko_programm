using System;
using Task_03;

namespace task3
{
    public class Task3
    {
        public static bool checkUp(string input)
        {
            if (!DateTime.TryParse(input, out DateTime result))
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
            Console.Write("Enter the date: ");
            string input = Console.ReadLine();
            while (!checkUp(input))
            {
                Console.Write("Enter the date: ");
                input = Console.ReadLine();
            }
            DateTime date = DateTime.Parse(input);
            Console.WriteLine("The day of week is " + DateService.GetDay(date));

            Console.WriteLine("Between the date and today's date - " + 
                DateService.GetDaysSpan(date.Day, date.Month, date.Year) + " days");
        }
    }
}