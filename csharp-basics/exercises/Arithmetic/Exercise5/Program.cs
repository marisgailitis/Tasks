using System;

class Program
{
    private static void Main(string[] args)
    {
		int lowest = 1;
		int highest = 101;

		Random random = new Random();
		int randomNumber = random.Next(lowest, highest);

        Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
		GetInput:
        string userInput = Console.ReadLine();
		(int, bool) numberAcquired = GetNumberFromInput(userInput);

		if(!numberAcquired.Item2)
		{
			Console.WriteLine("I'm still thinking of the number, so input one this time");
			goto GetInput;
		}

		int number = numberAcquired.Item1;

		if(number > 100 || number < 1)
		{
			Console.WriteLine("I said between 1 and 100, stick within the range");
			goto GetInput;
		}

		string message = EvaluateNumberMessage(number, randomNumber);

		Console.WriteLine(message);
        Console.Read();
    }

	private static string EvaluateNumberMessage(int input, int randomNumber)
	{
		if(input < randomNumber) return $"Sorry, you are too low.  I was thinking of {randomNumber}";
		if(input > randomNumber) return $"Sorry, you are too high.  I was thinking of {randomNumber}";
		else return "You guessed it!  What are the odds?!?";
	}

	private static (int, bool) GetNumberFromInput(string input)
	{
		char[] chars = input.ToCharArray();

		for(int i = 0; i < chars.Length; i++)
		{
			if(!char.IsDigit(chars[i]))
			{
				chars[i] = ' ';
			}
		}

		string newString = new string(chars);
		string[] newStrings = newString.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

		List<int> numbers = new List<int>();

		foreach (string s in newStrings)
        {
			numbers.Add(int.Parse(s));
        }

		if(numbers.Count == 0) return (0, false);

		else return (numbers[0], true);
	}
}