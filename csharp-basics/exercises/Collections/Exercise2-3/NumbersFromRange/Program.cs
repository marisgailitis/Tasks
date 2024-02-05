using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var random = new Random();
			var numbers = new List<int>();
			while (numbers.Count() < 10)
			{
				numbers.Add(random.Next(1, 100));
			}

			IEnumerable<int> filteredNumbers = from n in numbers
													where (n > 30 && n < 100)
													select n;
			foreach(int num in filteredNumbers)
			{
				Console.WriteLine(num);
			}
		}
	}
}