﻿namespace ListExercise11
{
	class Program
	{
		static void Main(string[] args)
		{
			//TODO: Create an List with string elements

			List<string> strings = new List<string>();

			//TODO: Add 10 values to list

			for (int i = 0; i < 10; i++)
			{
				strings.Add(i.ToString());
			}

			//TODO: Add new value at 5th position

			strings.Insert(4, "4.1");

			//TODO: Change value at last position (Calculate last position programmatically)

			strings[strings.Count - 1] = "0";

			//TODO: Sort your list in alphabetical order

			strings.Sort();

			//TODO: Check if your list contains "Foobar" element

			Console.WriteLine($"Does contain Foobar? : {strings.Contains("Foobar")}");

			//TODO: Print each element of list using loop

			foreach (string s in strings)
			{
				Console.WriteLine(s);
			}
		}
	}
}