using System;
using System.Globalization;

namespace Exercise11
{
    class Program
    {
        public static void Main()
		{
			Account bartosAccount = new Account("Barto's account", 100);
			Account bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000);

			Console.WriteLine("Initial state");
			Console.WriteLine(bartosAccount);
			Console.WriteLine(bartosSwissAccount);

			bartosAccount.Withdraw(20);
			Console.WriteLine("Barto's account balance is now: " + bartosAccount.Balance);
			bartosSwissAccount.Deposit(200);
			Console.WriteLine("Barto's Swiss account balance is now: " + bartosSwissAccount.Balance);

			Console.WriteLine("Final state");
			Console.WriteLine(bartosAccount);
			Console.WriteLine(bartosSwissAccount);

			Account mattsAccount = new Account("Matt's account", 1000);
			Account myAccount = new Account("My's account", 0);

			AccountUtilities.Transfer(mattsAccount, myAccount, 100);

			Console.WriteLine($"Matt's account balance { AccountUtilities.DisplayCurrency(mattsAccount.Balance) }");
			Console.WriteLine($"Matt's account balance { AccountUtilities.DisplayCurrency(myAccount.Balance) }");

			Account a = new Account("A", 100);
			Account b = new Account("B", 0);
			Account c = new Account("C", 0);

			AccountUtilities.Transfer(a, b, 50);
			AccountUtilities.Transfer(b, c, 25);

			Console.WriteLine($"A account balance { AccountUtilities.DisplayCurrency(a.Balance) }");
			Console.WriteLine($"B account balance { AccountUtilities.DisplayCurrency(b.Balance) }");
			Console.WriteLine($"C account balance { AccountUtilities.DisplayCurrency(c.Balance) }");
		}

		
    }
}