using System.Text;

namespace Exercise5
{
    class Program
    {
		private static void Main(string[] args)
        {
            while(true)
			{
				Console.WriteLine("Enter a number");
				string input = Console.ReadLine();

				if(int.TryParse(input, out _))
				{
					int number = 0;

					foreach(char c in input)
					{
						int d = char.GetNumericValue(c);
						number += d * d;
					}
					
					if(number % 10 == 1)
						Console.WriteLine("Number is happy");
					else
						Console.WriteLine("Number is not happy");
				}
				else
				{
					break;
				}
			}
        }
    }
}