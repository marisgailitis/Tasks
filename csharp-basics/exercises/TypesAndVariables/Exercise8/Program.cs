using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number of minutes");
        string userInput = Console.ReadLine();
		double sum = ParseToDouble(userInput);

		double minutesInYear = 525948.766;
		double minutesInDay = 1440;

		int numberOfYears = (int)(sum / minutesInYear);
		double remainderForDays = sum - numberOfYears * minutesInYear;
		double numberOfDays = Double.Round(remainderForDays / minutesInDay, 2);

        Console.WriteLine($"The number of years is : {numberOfYears}");
		Console.WriteLine($"The number of days is : {numberOfDays}");
    }

	private static double ParseToDouble(string input)
	{
		double minutes = 0;

		try
        {
            minutes = double.Parse(input);
        }
		catch(Exception e)
		{
			Console.WriteLine($"An exception occurred: {e.Message}");
		}

		return minutes;
	}
}