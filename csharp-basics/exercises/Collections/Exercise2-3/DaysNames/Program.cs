using System;

namespace DaysNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> dateTimes = new List<DateTime>();

			dateTimes.Add(new DateTime(2005, 07, 12));
			dateTimes.Add(new DateTime(1923, 01, 15));
			dateTimes.Add(new DateTime(1970, 11, 29));
			dateTimes.Add(new DateTime(2009, 05, 14));
			dateTimes.Add(new DateTime(53, 02, 26));

			foreach(DateTime dt in dateTimes)
			{
				Console.WriteLine($"Day of the date {dt} is {dt.DayOfWeek}");
			}
        }
    }
}