using System;
using System.Text;

namespace Exercise7
{
    internal class Program
    {
		private const int LEVELS = 5;

        static void Main(string[] args)
        {
            int totalSymbols = 8 * (LEVELS - 1);
			
			for(int i = 0; i < LEVELS; i++)
			{
				int numberofStars = 8 * i;
				int remaindingSymbols = totalSymbols - numberofStars;

				StringBuilder sb = new StringBuilder();

				for(int j = 0; j < remaindingSymbols / 2; j++)
				{
					sb.Append('/');
				}
				for(int j = 0; j < numberofStars; j++)
				{
					sb.Append('*');
				}
				for(int j = 0; j < remaindingSymbols / 2; j++)
				{
					sb.Append('\\');
				}

				Console.WriteLine(sb.ToString());
			}
        }
    }
}