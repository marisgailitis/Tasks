using System;

namespace Exercise3
{    
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};

            int sum = 0;
            double average = 0;
            int length = numbers.Length;

            for (int i = 0; i < length; i++)
            {
                sum += numbers[i];
            }

            average = (double)sum / length;

            Console.WriteLine("Average value of the array elements is : " + average);
        }
    }
}
