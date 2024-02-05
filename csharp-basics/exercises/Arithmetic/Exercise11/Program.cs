using System;

class Program
{
    private static void Main(string[] args)
    {
		int number = 0;
		int[] digits = new int[0];
		GetInput(ref number, ref digits);

		int sumOfDigits = 0;

		foreach(int i in digits)
		{
			sumOfDigits += i;
		}

		string message = EvaluateNumber(number, sumOfDigits);

		Console.WriteLine(message);
    }

	private static string EvaluateNumber(int number, int sumOfDigits)
	{
		bool isMoran = IsMoran(number, sumOfDigits);
		if(isMoran) return "Moran";

		if(number % sumOfDigits == 0) return "Harshad";


		return "Neither";
	}

	private static bool IsMoran(int number, int sumOfDigits)
	{
		if(number < 2) return false;

		int division = number / sumOfDigits;

		for (int i = 2; i < division; i ++)
        	if (division % i == 0)
				return false;

		return true;
	}

	private static void GetInput(ref int number, ref int[] digits)
	{
		Console.WriteLine("Enter a number");
		GetNumberInput:
        string userInput = Console.ReadLine();

		if(int.TryParse(userInput, out number))
		{
			char[] chars = userInput.ToCharArray();

			digits = new int[userInput.Length];
			for(int i = 0; i < digits.Length; i++)
			{
				digits[i] = int.Parse(chars[i].ToString());
			}
		}
		else
		{
			Console.WriteLine("Could not parse to a number");
			goto GetNumberInput;
		}
	}
}