using System.Linq;
using System.Net.Mail;

namespace Excercise7
{
    public static class SavingsAdditionalMethods
	{
		public static decimal Deposit(this SavingsAccount account)
		{
			decimal amount = account.GetAmount();
			account.ChangeBalance(amount);
			return amount;
		}
		public static decimal Withdraw(this SavingsAccount account)
		{
			decimal amount = account.GetAmount();
			account.ChangeBalance(-amount);
			return amount;
		}
		public static decimal AddInterest(this SavingsAccount account)
		{
			decimal amount = account.Balance / 12 * account.Interest;
			account.ChangeBalance(amount);
			return amount;
		}
    }
}