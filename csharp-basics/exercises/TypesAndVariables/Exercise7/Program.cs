using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string userInput = Console.ReadLine();
		int sum = CountUppercases(userInput);
        Console.WriteLine($"The number of uppercases in the string entered is : {sum}");
    }

	private static int CountUppercases(string input)
	{
		int sum = 0;

		foreach (char c in input)
        {
			if(char.IsUpper(c))
			{
				sum++;
			}
        }

		return sum;
	}
}