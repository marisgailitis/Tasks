using System;
using System.Text;

namespace Exersise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word");
			string first = Console.ReadLine();
			Console.WriteLine("Enter second word");
			string second = Console.ReadLine();

			int combinedLength = first.Length + second.Length;
			int remainder = 30 - combinedLength;

			StringBuilder builder = new StringBuilder();

			builder.Append(first);
			for(int i = 0; i < remainder; i++)
			{
				builder.Append('.');
			}
			builder.Append(second);

			Console.WriteLine(builder.ToString());
        }
    }
}