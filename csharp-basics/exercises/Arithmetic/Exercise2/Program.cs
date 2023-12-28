class Program
{
    private static void Main(string[] args)
    {
		GetInput:
        Console.WriteLine("Enter a number");
        string userInput = Console.ReadLine();
		(int, bool) numberAcquired = GetNumberFromInput(userInput);

		if(!numberAcquired.Item2)
		{
			Console.WriteLine("Could not find a number in the input");
			goto GetInput;
		}

		int number = numberAcquired.Item1;

		string message = number % 2 == 0? "Even Number" : "Odd Number";

		Console.WriteLine(message);
		Console.WriteLine("bye!");
        Console.Read();
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