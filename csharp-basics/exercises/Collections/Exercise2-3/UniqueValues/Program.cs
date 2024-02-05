using System;
using System.Collections.Generic;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            Dictionary<string, int> repetitions = new Dictionary<string, int>();

            foreach (string s in values)
            {
                if (repetitions.ContainsKey(s))
                {
                    repetitions[s]++;
                }
                else
                {
                    repetitions.Add(s, 0);
                }
            }

            List<string> uniques = new List<string>();

            foreach (KeyValuePair<string, int> occurrence in repetitions)
            {
                if (occurrence.Value == 0)
                {
                    uniques.Add(occurrence.Key);
                }
            }

            foreach (string s in uniques)
            {
                Console.WriteLine(s);
            }
        }
    }
}