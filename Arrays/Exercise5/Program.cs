using System;
using System.Collections.Generic;

namespace Exercise5
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] myArray = {25, 14, 56, 15, 36, 56, 77, 18, 29, 49};

            var indexOfElement36 = -1;
            var indexOfElement29 = -1;

            CheckIndex(36);
            CheckIndex(29);
        }

        private static void CheckIndex(int number)
        {
            for (int i = 0; i < myArray.Length; i++) 
            {
                if(myArray[i] == number)
                {
                    Console.WriteLine($"Index position of {number} is: {i}");
                }
            }
        }
    }
}
