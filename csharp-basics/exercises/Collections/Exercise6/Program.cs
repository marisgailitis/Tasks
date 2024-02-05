﻿using System;
using System.IO;

namespace Exercise6
{
	class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader sr = new StreamReader("lear.txt"))
			{
				int lineCount = 0;
				int wordCount = 0;
				int charCount = 0;

				string line;

				List<string> lines = new List<string>();

				while ((line = sr.ReadLine()) != null)
				{
					lines.Add(line);
					lineCount++;
				}

				foreach (string l in lines)
				{
					charCount += l.Length;

					string[] split = l.Split(' ');
					wordCount += split.Length;
				}

				Console.WriteLine($"Lines: {lineCount}");
				Console.WriteLine($"Words: {wordCount}");
				Console.WriteLine($"Chars: {charCount}");
			}
		}
	}
}