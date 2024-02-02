using System.Linq;
using System.Net.Mail;

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

			for(int i = 0; i < (int)account.TimeOpened; i++)
			{
				Console.WriteLine($"Enter amount deposited for month: { i }");
				totalDeposited += account.Deposit();
				Console.WriteLine($"Enter amount withdrawn for { i }");
				totalWithdrawn += account.Withdraw();
				interestEarned += account.AddInterest();
			}

			Console.WriteLine($"Total deposited: ${ totalDeposited }");
			Console.WriteLine($"Total deposited: ${ totalWithdrawn }");
			Console.WriteLine($"Total deposited: ${ Math.Round(interestEarned, 2) }");
		}
    }
}