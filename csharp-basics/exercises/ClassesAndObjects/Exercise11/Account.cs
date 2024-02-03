using System;
using System.Runtime.CompilerServices;

namespace Exercise11
{
    public class Account
    {
        public string Title { get; private set; }
		public decimal Balance { get; private set; }

		public Account(string title, decimal balance)
		{
			Title = title;
			Balance = balance;
		}

		public decimal Deposit(decimal amount) => ChangeBalance(amount);

		public decimal Withdraw(decimal amount) => ChangeBalance(-amount);

		private decimal ChangeBalance(decimal amount)
		{
			Balance += amount;
			return amount;
		}
    }
}