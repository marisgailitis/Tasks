using System;
using PersonData;

class Program
{
	static void Main(string[] args)
	{
		PersonBirthData personBirthData = new PersonBirthData("Juan Valdez", 1995);
		personBirthData.WriteBirthData();
		Console.Read();
	}
}