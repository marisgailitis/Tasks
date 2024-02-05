namespace Exercise10
{
	class Program
	{
		private static void Main(string[] args)
		{
			HashSet<string> strings = new HashSet<string>();

			for (int i = 0; i < 5; i++)
			{
				strings.Add(i.ToString());
			}
			foreach (string s in strings)
			{
				Console.WriteLine(s);
			}
			foreach (string s in strings)
			{
				Console.WriteLine($"Removing {s}");
				strings.Remove(s);
			}

			Console.WriteLine($"The remaining amount of elements is {strings.Count}");

			for (int i = 0; i < 5; i++)
			{
				string s = i.ToString();
				strings.Add(s);
				strings.Add(s);
			}
			foreach (string s in strings)
			{
				Console.WriteLine($"Removing {s}");
				strings.Remove(s);
			}

			Console.WriteLine($"The remaining amount of elements is {strings.Count}");

			// es tā sapratu, ka nevar duplikātus pievienot, citādi neizvadītos teksts tikai 5 reizes otrajā piegājienā, arī indeksot viņš neļauj
		}
	}
}