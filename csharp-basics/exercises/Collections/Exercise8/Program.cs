﻿using System;
using System.IO;

namespace Exercise8
{
	class Program
	{
		private static void Main(string[] args)
		{
			int[] markCounts = new int[11];

			using (StreamReader sr = new StreamReader("midtermscores.txt"))
			{
				string line = sr.ReadLine();
				string[] separatedLine = line.Split(' ');

				int[] allMarks = new int[separatedLine.Length];

				for (int i = 0; i < allMarks.Length; i++)
				{
					allMarks[i] = Int32.Parse(separatedLine[i]);
				}
				//divide everything by 10 to get rid of the remainder and this way determine which mark range it belongs to
				for (int i = 0; i < allMarks.Length; i++)
				{
					int markIndex = allMarks[i] / 10;
					markCounts[markIndex]++;
				}
			}
			for (int i = 0; i < markCounts.Length; i++)
			{
				int rangeStart = i * 10;
				int rangeEnd = rangeStart + 9;

				string markRange = i < 10 ? $"{rangeStart} - {rangeEnd}: " : $"{rangeStart}: ";
				Console.Write(markRange);

				for (int j = 0; j < markCounts[i]; j++)
					Console.Write("*");

				Console.WriteLine("\n");
			}
		}
	}
}