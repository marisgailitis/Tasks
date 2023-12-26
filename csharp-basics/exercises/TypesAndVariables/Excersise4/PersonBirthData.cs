using System;

namespace PersonData
{
	class PersonBirthData
	{
		private string nameSurname;
		private int birthYear;

		public PersonBirthData(string nameSurname_, int birthYear_)
		{
			nameSurname = string.Copy(nameSurname_);
			birthYear = birthYear_;
		}

		public void WriteBirthData()
		{
			Console.WriteLine($"My name is {nameSurname} and I was born in {birthYear}");
		}
	}
}