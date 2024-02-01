using System;
using System.Collections.Generic;

namespace Exercise9
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] names = {"samuel", "MABELLE", "letitia", "meridith"};

			for(int i = 0; i < names.Length; i++)
			{
				string name = names[i].ToLower();
				List<char> chars = name.ToList();


				chars[0] = Char.ToUpper(chars[0]);
				names[i] = new string(chars.ToArray());
			}

			foreach(string name in names)
			{
				Console.Write($"{name} ");
			}
        }
    }
}
