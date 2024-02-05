using System.Linq;
using System.Net.Mail;

namespace Excercise9
{
	public class Program
	{
		static void Main()
		{
			BankAccount account = new BankAccount("BenBen", -17.5m);
			Console.WriteLine(account.ShowUserNameAndBalance());
		}
	}
}