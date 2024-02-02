using System;
using System.Globalization;

namespace Excercise1
{
    internal class Product
    {
		private string name;
		private decimal priceAtStart;
		private int amount;

        public Product(string name_, decimal priceAtStart_, int amount_)
		{
			name = name_;
			priceAtStart = priceAtStart_;
			amount = amount_;
		}

		public void PrintProduct()
		{
			Console.WriteLine($"{name}, {priceAtStart.ToString("C", CultureInfo.CreateSpecificCulture("de-DE"))}, {amount}");
		}

		public void ChangeQuantity(int newAmount)
		{
			amount = newAmount;
		}

		public void ChangePrice(decimal newPrice)
		{
			priceAtStart = newPrice;
		}
    }
}