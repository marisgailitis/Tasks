﻿using System;
using System.Collections.Generic;

namespace DecryptNumber
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var cryptedNumbers = new List<string>
			{
				"())(",
				"*$(#&",
				"!!!!!!!!!!",
				"$*^&@!",
				"!)(^&(#@",
				"!)(#&%(*@#%"
			};

			Dictionary<char, int> decrypting = new Dictionary<char, int>();

			decrypting.Add('!', 1);
			decrypting.Add('@', 2);
			decrypting.Add('#', 3);
			decrypting.Add('$', 4);
			decrypting.Add('%', 5);
			decrypting.Add('^', 6);
			decrypting.Add('&', 7);
			decrypting.Add('*', 8);
			decrypting.Add('(', 9);
			decrypting.Add(')', 0);

			for (int i = 0; i < cryptedNumbers.Count; i++)
			{
				char[] chars = cryptedNumbers[i].ToCharArray();

				for (int j = 0; j < chars.Length; j++)
				{
					chars[j] = (char)(decrypting[chars[j]] + '0');
				}

				string decrypted = new string(chars);
				cryptedNumbers[i] = decrypted;
			}

			foreach (string s in cryptedNumbers)
			{
				Console.WriteLine(s);
			}
		}
	}
}