using System;

class Program
{
	private int hours, minutes, seconds;
	private double distance;
	private static Program singleton;

    private static void Main(string[] args)
    {
		if(singleton == null) singleton = new Program();

		GetDouble("Enter a distance in meters", ref singleton.distance);
		GetInt("Enter time in hours", ref singleton.hours);
		GetInt("Enter time in minutes", ref singleton.minutes);
		GetInt("Enter time in seconds", ref singleton.seconds);

		double totalSeconds = (double)(singleton.seconds + singleton.minutes * 60 + singleton.hours * 3600);
		double mps = singleton.distance / totalSeconds;
		double kmh = mps * 3.6;
		double mph = kmh / 1.609;

        Console.WriteLine($"Your speed in meters/second is {mps}");
		Console.WriteLine($"Your speed in km/h is {kmh}");
		Console.WriteLine($"Your speed in miles/h is {mph}");
    }

	private static double GetDouble(string message, ref double variable)
	{
		Console.WriteLine(message);
		string userInput = Console.ReadLine();
		variable = ParseToDouble(userInput);
		return 0;
	}

	private static double GetInt(string message, ref int variable)
	{
		Console.WriteLine(message);
		string userInput = Console.ReadLine();
		variable = ParseToInt(userInput);
		return 0;
	}

	private static double ParseToDouble(string input)
	{
		double number = 0;

		try
        {
            number = double.Parse(input);
        }
		catch(Exception e)
		{
			Console.WriteLine($"An exception occurred: {e.Message}");
		}

		return number;
	}
	private static int ParseToInt(string input)
	{
		int number = 0;

		try
        {
            number = int.Parse(input);
        }
		catch(Exception e)
		{
			Console.WriteLine($"An exception occurred: {e.Message}");
		}

		return number;
	}
}