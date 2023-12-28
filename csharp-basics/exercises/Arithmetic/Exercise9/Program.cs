class Program
{
	static void Main(string[] args)
	{
		double poundMultiplier = 0.45359237;
		double inchMultiplier = 2.54;

		Console.WriteLine($"Input weight in kilograms");
		double weight = double.Parse(Console.ReadLine());

		Console.WriteLine($"Input height in centimeters");
		double height = double.Parse(Console.ReadLine());

		double weightInPounds = double.Round(weight / poundMultiplier, 2);
		double heightInInches = double.Round(height / inchMultiplier, 2);

		double bmi = weightInPounds * 703 / heightInInches / heightInInches;

		string verdict = "normal";

		if(bmi < 18.5) verdict = "underweight";

		else if(bmi > 25) verdict = "overweight";

		Console.WriteLine($"The person with weight in lbs {weightInPounds} and height in inches {heightInInches} has a BMI of {bmi} and is considered {verdict}");
	}
}