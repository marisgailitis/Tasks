using System;

namespace Exercise10
{
    class Program
    {
		private static List<int> numberCharacters = new List<int>();

        static void Main(string[] args)
        {
            InitializeList();
			MoveList();
        }

		private static void InitializeList()
		{
			Console.WriteLine("Enter two numbers from lowest to highest");

			while(true)
			{
				string input = Console.ReadLine();
            	string[] numbers = input.Split(' ');

				if (numbers.Length < 2) Console.WriteLine("Two numbers are needed");

				try
				{
					int min = int.Parse(numbers[0]);
					int max = int.Parse(numbers[1]);

					if(min > 0 && min < 10 && min < max)
					{
						for(int i = min; i < max + 1; i++)
						{
							numberCharacters.Add(i);
						}
						break;
					}
				}
				catch
				{
					Console.WriteLine("Could not get numbers from the input");
				}
			}
		}

		private static void MoveList()
		{
			for(int i = 0; i < numberCharacters.Count * 2; i++)
			{
				Console.WriteLine(String.Join(" ", numberCharacters));

				int lastIndex = numberCharacters.Count - 1;
				int lastNumber = numberCharacters[lastIndex];
				numberCharacters.RemoveAt(lastIndex);
				numberCharacters.Insert(0, lastNumber);
			}
		}
	}
}