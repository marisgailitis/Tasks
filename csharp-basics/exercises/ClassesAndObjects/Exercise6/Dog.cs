using System.Linq;
using System.Net.Mail;

namespace Excercise6
{
    public class Dog
    {
        public string Name { get; private set;}
		public Gender Sex { get; private set;}
		public Dog Mother { get; set;}
		public Dog Father { get; set;}

		public Dog(string Name_, Gender Sex_)
		{
			Name = Name_;
			Sex = Sex_;
		}

		public enum Gender
		{
			Male,
			Female
		}
    }
}