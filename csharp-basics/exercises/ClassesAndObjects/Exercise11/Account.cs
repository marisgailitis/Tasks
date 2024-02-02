using System;
using System.Runtime.CompilerServices;

namespace Exercise11
{
    public class Account
    {
        public string Title { get; private set; }
		public double Balance { get; private set; }

		public Account(string title, double balance)
		{
			Title = title;

			Balance = balance;
		}

		public double Deposit(double amount) => ChangeBalance(-amount);

		public double Withdraw(double amount) => ChangeBalance(-amount);

		private double ChangeBalance(double amount)
		{
			Balance += amount;

			return -amount;
		}
    }
}