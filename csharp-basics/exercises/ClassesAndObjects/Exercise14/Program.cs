﻿namespace Exercise14
{
	class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine(Date.GetDay(new DateTime(1970, 9, 21)));
			Console.WriteLine(Date.GetDay(new DateTime(1945, 9, 2)));
			Console.WriteLine(Date.GetDay(new DateTime(2001, 9, 11)));
		}
	}
}