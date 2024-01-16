using System;

namespace Exercise8
{
    internal class Piglet
    {
		private static int _score = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Piglet!");

			while(true)
			{
				RollDice();

				if(!ContinueGame())
				{
					break;
				}
			}

			Console.WriteLine($"You got {_score} points.");
        }

		private static void RollDice()
		{
			Random random = new Random();

			int diceThrow = random.Next(1, 7);

			Console.WriteLine($"You rolled a {diceThrow}!");

			if(diceThrow > 1)
				_score += diceThrow;
			else
				_score = 0;
		}

		private static bool ContinueGame()
		{
			if(_score > 0)
			{
				Console.WriteLine("Roll again?");
				return WaitForResponse();
			}
			else
			{
				return false;
			}
		}

		private static bool WaitForResponse()
		{
			while(true)
			{
				string input = Console.ReadLine();

				if(input is string)
				{
					if(input == "yes" || input[0] == 'y')
						return true;
					else if(input == "no" || input[0] == 'n')
						return false;
				}
			}
		}
    }
}