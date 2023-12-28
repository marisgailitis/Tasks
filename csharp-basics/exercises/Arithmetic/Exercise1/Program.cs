using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    private static void Main(string[] args)
    {
		List<int> numbers = new List<int>();

		GetInput:
        Console.WriteLine("Enter two integers");
        string userInput = Console.ReadLine();
		GetNumbersFromInput(userInput, ref numbers);

		if(numbers.Count < 2)
		{
			goto GetInput;
		}

		bool isTrue = IsFifteen(numbers);
		string message = isTrue? "The result is fifteen" : "The result is anything but fifteen";

		Console.WriteLine(message);
        Console.Read();
    }

	private static bool IsFifteen(List<int> numbers)
	{
		int first = numbers[0];
		int second = numbers[1];
		bool eitherIsFifteen = first == 15 || second == 15;
		bool sumOrDifferenceFifteen = first + second == 15 || first - second == 15 || second - first == 15;

		return eitherIsFifteen || sumOrDifferenceFifteen;
	}

	private static void GetNumbersFromInput(string input, ref List<int> numbers)
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

		foreach (string s in newStrings)
        {
			numbers.Add(int.Parse(s));
        }
	}
}