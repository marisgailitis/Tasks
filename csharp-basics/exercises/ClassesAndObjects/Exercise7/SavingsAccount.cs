using System.Linq;
using System.Net.Mail;

namespace Excercise7
{
	public class SavingsAccount
	{
		public decimal Balance { get; private set; }
		public decimal Interest { get; private set; }
		public decimal TimeOpened { get; private set; }

		public SavingsAccount()
		{
			Console.WriteLine("How much money is in the account?");
			Balance = GetAmount();
			Console.WriteLine("Enter the annual interest rate");
			Interest = GetAmount();
			Console.WriteLine("How long has the account been opened?");
			TimeOpened = GetAmount();
		}

		public decimal GetAmount()
		{
			bool parsed = false;

			while (!parsed)
			{
				decimal number;
				parsed = decimal.TryParse(Console.ReadLine(), out number);

				if (parsed)
				{
					return number;
				}
				else
				{
					Console.WriteLine("Parsing failed.");
				}
			}

			return 0;
		}

		public void ChangeBalance(decimal amount)
		{
			Balance += amount;
		}
	}
}