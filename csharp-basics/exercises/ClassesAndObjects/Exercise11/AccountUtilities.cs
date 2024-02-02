using System;
using System.Runtime.CompilerServices;

namespace Exercise11
{
    public static class AccountUtilities
    {
        public static void Transfer(Account from, Account to, double howMuch)
		{
			from.Withdraw(Math.Round(howMuch, 2));
			to.Deposit(Math.Round(howMuch, 2));
		}
    }
}