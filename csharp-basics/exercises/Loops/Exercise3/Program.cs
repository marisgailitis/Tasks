using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] numbers = new int[20];

			Random random = new Random();

			for(int i = 0; i < numbers.Length; i++)
			{
				numbers[i] = random.Next(int.MinValue, int.MaxValue);
			}

			while(true)
			{
				Console.WriteLine("Which number position out of 20 random numbers do you wish to know?");
				string input = Console.ReadLine();

				try
				{
					uint choice  = UInt32.Parse(input);
					if(choice >= 0 && choice < 20)
					{
						Console.WriteLine($"You picked {numbers[choice]}");
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
