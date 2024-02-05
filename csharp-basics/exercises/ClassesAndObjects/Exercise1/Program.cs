using System;

namespace Excercise1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Product epson = new Product("Epson EB-U05", 440.46m, 1);
			Product mouse = new Product("Logitech Mouse", 70m, 14);
			Product iPhone = new Product("iPhone 5s", 999.99m, 3);

			Console.WriteLine("Change the price of Epson EB-U05");
			epson.ChangePrice(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Change the price of Logitech Mouse");
			mouse.ChangePrice(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Change the price of iPhone 5s");
			iPhone.ChangePrice(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Change the quantity of Epson EB-U05");
			epson.ChangeQuantity(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Change the quantity of Logitech Mouse");
			mouse.ChangeQuantity(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Change the quantity of iPhone 5s");
			iPhone.ChangeQuantity(Convert.ToInt32(Console.ReadLine()));

			Console.WriteLine("Press any key to view products");
			Console.Read();

			epson.PrintProduct();
			mouse.PrintProduct();
			iPhone.PrintProduct();

			Console.Read();
		}
	}
}