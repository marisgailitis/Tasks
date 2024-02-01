using System;
using System.Collections.Generic;

namespace Exercise6
{
    class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();

            int length = 10;
            int[] values = new int[length];
            int[] copiedValues = new int[length];

            for(int i = 0; i < length; i++)
            {
                values[i] = random.Next(0, 100);
            }

            values.CopyTo(copiedValues, 0);
            values[length - 1] = -7;

            string firstValues = string.Join(" ", values);
            string secondValues = string.Join(" ", copiedValues);

            Console.WriteLine($"Array 1: { firstValues }");
            Console.WriteLine($"Array 2: { secondValues }");
        }
    }
}
