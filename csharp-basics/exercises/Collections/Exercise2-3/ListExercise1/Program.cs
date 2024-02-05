﻿using System;

namespace ListExercise1
{
	class Program
	{
		private static void Main(string[] args)
		{
			List<string> colorNames = new List<string>();

			colorNames.Add("red");
			colorNames.Add("blue");
			colorNames.Add("green");
			colorNames.Add("yellow");
			colorNames.Add("white");

			foreach (string color in colorNames)
			{
				Console.WriteLine(color);
			}
		}
	}
}