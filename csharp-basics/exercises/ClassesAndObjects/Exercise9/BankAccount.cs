public class BankAccount
{
	public string Name { get; private set; }
	public decimal Balance { get; private set; }

	public BankAccount(string name, decimal balance)
	{
		Name = name;
		Balance = balance;
	}
}