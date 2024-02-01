using System;
using System.Collections.Generic;

namespace Exercise10
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {92, 6, 73, -77, 81, -90, 99, 8, -85, 34};
			int[] results = GetResult(numbers);

			foreach(int result in results)
			{
				Console.Write($"{result} ");
			}
        }
		private static int[] GetResult(int[] numbers)
		{
			if(numbers.Length == 0)
			{
				return new int[0];
			}

			int positiveNumberCount = 0;
			int sumOfNegatives = 0;

			for(int i = 0; i < numbers.Length; i++)
			{
				int number = numbers[i];

				if(number > 0)
				{
					positiveNumberCount++;
				}
				if(number < 0)
				{
					sumOfNegatives += number;
				}
			}
			
			int[] results = { positiveNumberCount, sumOfNegatives };
			return results;
		}
    }
}
