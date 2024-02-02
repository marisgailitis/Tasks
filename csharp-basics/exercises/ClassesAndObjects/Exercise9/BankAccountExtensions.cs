using System.Linq;
using System.Net.Mail;

namespace Excercise9
{
    public static class BankAccountExtensions
    {
        public static string ShowUserNameAndBalance(this BankAccount account)
		{
			string minusSign = account.Balance < 0? "-" : "";
			return ($"{ account.Name}, {minusSign}${ account.Balance.ToString("F2") }");
		}
    }
}