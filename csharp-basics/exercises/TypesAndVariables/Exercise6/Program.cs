using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a series of single digit numbers");
        string userInput = Console.ReadLine();
		(int, bool) sum = AnalyzeInput(userInput);

		if(!sum.Item2) return;

        Console.WriteLine($"The sum is : {sum.Item1}");
    }

	private static (int, bool) AnalyzeInput(string input)
	{
		int sum = 0;

		foreach (char c in input)
        {
			try
			{
				sum += int.Parse(c.ToString());
			}
			catch (Exception e)
			{
				Console.WriteLine($"Only single digit numbers allowed");
			}
        }

		return (sum, true);
	}
}