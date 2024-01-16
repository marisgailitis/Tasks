using System;

namespace Exercise9
{
    internal class RollTwoDice
    {
		private static int _wantedSum = 0;

        static void Main(string[] args)
        {
            GetWantedSum();
			ThrowDices();
        }

		private static void GetWantedSum()
		{
			Console.WriteLine("Enter your desired sum");

			while(true)
			{
				string input = Console.ReadLine();

				_wantedSum = int.Parse(input);

				if(_wantedSum is int && _wantedSum >=2 && _wantedSum <=12)
					break;
				else
					Console.WriteLine("Enter number from 2 to 12");
			}
		}

		private static void ThrowDices()
		{
			Random random = new Random();

			while(true)
			{
				int one = random.Next(1, 7);
				int two = random.Next(1, 7);
				int sum = one + two;

				Console.WriteLine($"{one} and {two} = {sum}");

				if(sum == _wantedSum)
				{
					break;
				}
			}
		}
    }
}