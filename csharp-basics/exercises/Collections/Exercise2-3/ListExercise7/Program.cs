﻿using System.Collections.Generic;

namespace ListExercise7
{
	class Program
	{
		static void Main(string[] args)
		{
			var colors = new List<string>
			{
				"Red",
				"Green",
				"Orange",
				"White",
				"Black"
			};

			//      TODO: Check if list contains "White" element

			if (colors.Contains("White"))
				Console.WriteLine("Contains");
			else
				Console.WriteLine("Nope");
		}
	}
}