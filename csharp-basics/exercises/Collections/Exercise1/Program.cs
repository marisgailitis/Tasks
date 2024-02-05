﻿using System.Text;

namespace Exercise1
{
    class Program
    {
		private static Dictionary<string, string> dictionary = new Dictionary<string, string>();

        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> list = new List<string>() { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

			HashSet<string> hashSet = new HashSet<string>() { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

			InitializeDictionary();

            foreach(string str in list)
			{
				Console.Write($"List: {str}, ");
			}
			Console.WriteLine();

			foreach(string hash in hashSet)
			{
				Console.Write($"HashSet: {hash}, ");
			}
			Console.WriteLine();

			StringBuilder builder = new StringBuilder();
			builder.Append("Dictionary: ");

			foreach(KeyValuePair<string, string> d in dictionary)
			{
				builder.Append($"{d.Value}, ");
			}
			Console.Write(builder.ToString());
        }

		private static void InitializeDictionary()
        {
            dictionary.Add("Audi", "Germany");
			dictionary.Add("BMW", "Germany");
			dictionary.Add("Honda", "Japan");
			dictionary.Add("Mercedes", "Germany");
			dictionary.Add("VolksWagen", "Germany");
			dictionary.Add("Tesla", "USA");
        }
    }
}