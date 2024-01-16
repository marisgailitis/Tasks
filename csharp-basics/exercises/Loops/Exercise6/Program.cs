using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise6
{
    internal class Program
    {
		private static List<MultiplierStringPair> pairs = new List<MultiplierStringPair>();
		private static int _maxNumber = 0;

        static void Main(string[] args)
        {
            Initialize();
			GetMaxNumber();
			Count();
        }

		private static void Initialize()
		{
			//we could keep adding multipliers indefinitely without having to copy code much
			pairs.Add( new MultiplierStringPair("Fizz", new List<int>(){ 3 }) );
			pairs.Add( new MultiplierStringPair("Buzz", new List<int>(){ 5 }) );
			pairs.Add( new MultiplierStringPair("FizzBuzz", new List<int>(){ 3, 5 }) );
		}

		private static void GetMaxNumber()
		{
			Console.WriteLine("Enter the max number");
			_maxNumber = int.Parse(Console.ReadLine());
		}

		private static string PickPhrase(int number)
		{
			int largestMultiplierAmount = 0;
			string currentPhrase = string.Empty;

			for(int i = 0; i < pairs.Count; i++)
			{
				bool isMultilier = true;

				MultiplierStringPair pair = pairs[i];

				for(int j = 0; j < pair.multiplierNumbers.Count; j++)
				{
					if(number % pair.multiplierNumbers[j] != 0)
					{
						isMultilier = false;
						break;
					}
				}

				if(isMultilier && pair.multiplierNumbers.Count > largestMultiplierAmount)
				{
					largestMultiplierAmount = pair.multiplierNumbers.Count;
					currentPhrase = pair.phrase;
				}
			}

			if(largestMultiplierAmount > 0)
				return currentPhrase;
			else
				return number.ToString();
		}

		private static void Count()
		{
			for(int i = 0; i < _maxNumber; i++)
			{
				Console.Write(string.Concat(" ", PickPhrase(i)));

				if(i % 20 == 0) 
					Console.Write("\n");
			}
		}

		internal class MultiplierStringPair
		{
			public MultiplierStringPair(string phrase_, List<int> multiplierNumbers_)
			{
				phrase = phrase_;
				multiplierNumbers = multiplierNumbers_;
			}

			public string phrase;
			public List<int> multiplierNumbers;
		}
    }
}