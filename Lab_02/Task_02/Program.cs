using System;

namespace lessons
{
	public class Program2
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

		public static bool secCheck(string choice)
		{
			if (choice.Length != 1) return false;
			if (choice[0] == 'Y' || choice[0] == 'N') return true;
			return false;
		}

		public static bool inArea(double x, double y)
        {
			if (Math.Abs(x) > Math.Abs(y)) return false;
			else if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 625) return true;
			else return false;
        }

		static double getNum(string phrase)
        {
			bool checkX = false;
			while (!checkX)
			{
				Console.WriteLine(phrase);
				string inputX = Console.ReadLine();

				checkX = checkUp(inputX);
				if (checkX) return double.Parse(inputX);
			}
			return 0;
		}

		public static bool border(double x, double y)
        {
			return (y == -Math.Abs(x) || Math.Pow(x, 2) + Math.Pow(y, 2) == 625);
		}

		static void result()
        {
			double x, y;
			x = getNum("Enter coordinates. x: ");
			y = getNum("y: ");

			if (inArea(x, y))
			{
				if (border(x, y))
				{
					Console.WriteLine("The pount is on the border of the sector.");
				}
				else Console.WriteLine("The pount is located inside the sector.");
			}
			else Console.WriteLine("The pount is loccated otside the sector.");

		}

		static void Main(string[] args)
		{
			result();
			bool contin = true;
			while (contin)
			{
				Console.WriteLine("Do you wish to proceed? (Y/N): ");
				string choice = Console.ReadLine();

				while (!secCheck(choice))
				{
					Console.WriteLine("invalid value, please, try again");
					choice = Console.ReadLine();
				}
				switch (choice[0])
				{
					case 'Y':
						result();
						break;
					case 'N':
						contin = false;
						break;
					default:
						return;
				}
			}
		}
	}
}