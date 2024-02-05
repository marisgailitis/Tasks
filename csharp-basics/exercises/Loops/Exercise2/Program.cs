using System;
using System.Numerics;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            BigInteger n = 0;
            BigInteger sum = 0;
            bool isInitialized = false;

            while(!isInitialized)
            {
                Console.WriteLine("Input number of terms : ");
                string input = Console.ReadLine();

                if(BigInteger.TryParse(input, out n))
                {
                    isInitialized = true;
                }
                else
                {
                    Console.WriteLine("Cannot parse to a BigInteger.");
                }
            }
            
            for (i = 0; i < n; i++)
            {
                sum += n * (n - i);
            }

            Console.WriteLine($"sum is {sum}");
            Console.Read();
        }
    }
}
