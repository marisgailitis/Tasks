using System;

namespace Exercise2
{
	class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Please enter a min number");
			int minNumber = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter a max number");
			int maxNumber = int.Parse(Console.ReadLine());

			int[] myArray = new int[maxNumber - minNumber];

			int sum = 0;

			for (int i = minNumber; i < maxNumber; i++)
			{
				myArray[i] = i;

				sum += i;
			}
			Console.WriteLine("The sum is " + sum);
			Console.ReadKey();
		}
	}
}
