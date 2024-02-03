using System;
using System.Globalization;

namespace Exercise11
{
    public static class AccountUtilities
    {
        public static void Transfer(Account from, Account to, decimal howMuch)
		{
			from.Withdraw(howMuch);
			to.Deposit(howMuch);
		}

		public static string DisplayCurrency(decimal amount)
		{
			CultureInfo cultureInfo = new CultureInfo("en-US");
			NumberFormatInfo numberFormatInfo = cultureInfo.NumberFormat;
			numberFormatInfo.CurrencyNegativePattern = 1;

			return ($"{ amount.ToString("C2", cultureInfo) }");
		}
    }
}