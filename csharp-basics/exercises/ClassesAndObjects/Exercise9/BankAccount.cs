using System.Globalization;

public class BankAccount
{
	public string Name { get; private set; }
	public decimal Balance { get; private set; }

	public BankAccount(string name, decimal balance)
	{
		Name = name;
		Balance = balance;
	}

	public string ShowUserNameAndBalance()
	{
		CultureInfo culture = new CultureInfo("en-US");
		NumberFormatInfo numberFormatInfo = culture.NumberFormat;
		numberFormatInfo.CurrencyNegativePattern = 1;
		return ($"{Name}, {Balance.ToString("C2", culture)}");
	}
}