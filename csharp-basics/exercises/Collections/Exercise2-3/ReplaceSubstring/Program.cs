﻿namespace ReplaceSubstring
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

			for (int i = 0; i < words.Length; i++)
			{
				if (words[i].Contains("ea"))
				{
					string censored = words[i].Replace("ea", "*");
					words[i] = censored;
				}
			}
			for (int i = 0; i < words.Length; i++)
			{
				Console.WriteLine(words[i]);
			}
		}
	}
}