class Program
{
    static void Main(string[] args)
    {
        const int lowerBound = 1;
        const int upperBound = 110;

        for (int i = lowerBound; i <= upperBound; i++)
        {
            string word = EvaluateNumber(i);
			Console.Write($"{word} ");

			if(i % 11 == 0) 
			{
				Console.WriteLine("\n");
			}
        }
    }
	private static string EvaluateNumber(int number)
	{
		bool multiplierOfThree = number % 3 == 0;
		bool multiplierOfFive = number % 5 == 0;
		bool multiplierOfSeven = number % 7 == 0;

		string word = multiplierOfThree || multiplierOfFive || multiplierOfSeven? "" : number.ToString();

		if(multiplierOfThree) word += "Coza";
		if(multiplierOfFive) word += "Loza";
		if(multiplierOfSeven) word += "Woza";
		
		return word;
	}
}