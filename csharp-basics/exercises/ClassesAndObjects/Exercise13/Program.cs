﻿using System.Globalization;

namespace Exercise13
{
	class Program
	{
		private static CultureInfo ukCulture = new CultureInfo("en-GB");
		private static Dictionary<string, Ingredient> ingredients = new Dictionary<string, Ingredient>();

		private static void Main(string[] args)
		{
			InitializeIngredients();

			Smoothie s1 = new Smoothie();
			s1.Ingredients = new Ingredient[] { ingredients["Banana"] };
			Console.WriteLine($"Cost: {AdjustCultureCost(s1.GetCost())}");
			Console.WriteLine($"Price: {AdjustCultureCost(s1.GetPrice())}");
			Console.WriteLine(s1.GetName());

			Smoothie s2 = new Smoothie();
			s2.Ingredients = new Ingredient[] { ingredients["Raspberries"], ingredients["Strawberries"], ingredients["Blueberries"] };
			Console.WriteLine($"Cost: {AdjustCultureCost(s2.GetCost())}");
			Console.WriteLine($"Price: {AdjustCultureCost(s2.GetPrice())}");
			Console.WriteLine(s2.GetName());
		}

		private static string AdjustCultureCost(double sum)
		{
			return sum.ToString("C", ukCulture);
		}

		private static void InitializeIngredients()
		{
			Ingredient strawberries = new Ingredient("Strawberries", 1.50);
			ingredients.Add(strawberries.Name, strawberries);

			Ingredient banana = new Ingredient("Banana", 0.50);
			ingredients.Add(banana.Name, banana);

			Ingredient mango = new Ingredient("Mango", 2.50);
			ingredients.Add(mango.Name, mango);

			Ingredient blueberries = new Ingredient("Blueberries", 1.00);
			ingredients.Add(blueberries.Name, blueberries);

			Ingredient raspberries = new Ingredient("Raspberries", 1.00);
			ingredients.Add(raspberries.Name, raspberries);

			Ingredient apple = new Ingredient("Apple", 1.75);
			ingredients.Add(apple.Name, apple);

			Ingredient pineapple = new Ingredient("Pineapple", 3.50);
			ingredients.Add(pineapple.Name, pineapple);
		}
	}
}