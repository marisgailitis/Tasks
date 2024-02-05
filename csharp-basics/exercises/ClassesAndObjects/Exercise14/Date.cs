using System.Globalization;

namespace Exercise14
{
	public static class Date
	{
		public static string GetDay(DateTime dateTime)
		{
			CultureInfo culture = new CultureInfo("nl-NL");
			string day = culture.DateTimeFormat.GetDayName(dateTime.DayOfWeek);
			return day;
		}
	}
}