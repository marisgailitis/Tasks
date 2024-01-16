using System;

namespace Exercise3
{
    class Program
    {
		private static int[] _numbers;

        static void Main(string[] args)
        {
			InitializeArray();
			DisplayIndex();
        }

		private static void InitializeArray()
		{
			_numbers = new int[20];

			Random random = new Random();

			for(int i = 0; i < _numbers.Length; i++)
			{
				_numbers[i] = random.Next(int.MinValue, int.MaxValue);
			}
		}

		private static void DisplayIndex()
		{
			while(true)
			{
				Console.WriteLine("Which number index out of 20 random numbers do you wish to know?");
				string input = Console.ReadLine();

				try
				{
					int choice  = Int32.Parse(input);
					if(choice >= 0 && choice < 21)
					{
						Console.WriteLine($"You picked {_numbers[choice]}");
						Console.Read();
						return;
					}
					Console.WriteLine("The number must be from 0 to 20");
				}
				catch
				{
					Console.WriteLine("Could not parse to a positive number");
				}
			}
		}
	}
}
