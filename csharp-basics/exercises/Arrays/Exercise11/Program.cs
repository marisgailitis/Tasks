using System;

namespace Exercise11
{
	class Program
	{
		public static void Main(string[] args)
		{
			string word = Search("I am finding Nemo");

			Console.WriteLine(word);
		}

		private static string Search(string sentence)
		{
			string[] words = sentence.Split(' ');

			for(int i = 0; i < words.Length; i++)
			{
				if(words[i] == "Nemo")
				{
					return $"I found Nemo at { i }!";
				}
			}
			return "I can't find Nemo :(";
		}
	}
}