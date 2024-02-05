using System.Linq;
using System.Net.Mail;

using System.Globalization;

namespace Excercise7
{
	public class Program
	{
		static void Main()
		{
			decimal totalDeposited = 0;
			decimal totalWithdrawn = 0;
			decimal interestEarned = 0;

			SavingsAccount account = new SavingsAccount();

			for (int i = 0; i < (int)account.TimeOpened; i++)
			{
				Console.WriteLine($"Enter amount deposited for month: {i + 1}");
				totalDeposited += account.Deposit();
				Console.WriteLine($"Enter amount withdrawn for {i + 1}");
				totalWithdrawn += account.Withdraw();
				interestEarned += account.AddInterest();
			}

			CultureInfo culture = new CultureInfo("en-US");
			Console.WriteLine($"Total deposited: {totalDeposited.ToString("C2", culture)}");
			Console.WriteLine($"Total withdrawn: {totalWithdrawn.ToString("C2", culture)}");
			Console.WriteLine($"Interest earned: {interestEarned.ToString("C2", culture)}");
			Console.WriteLine($"Ending balance: {account.Balance.ToString("C2", culture)}");
		}
	}
}