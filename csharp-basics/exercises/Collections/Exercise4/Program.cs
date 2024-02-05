using System.Text;

namespace Exercise4
{
	class Program
	{
		private static void Main(string[] args)
		{
			List<string> allNames = new List<string>();
			List<string> uniqueNames = new List<string>();

			while (true)
			{
				Console.WriteLine("Enter a name");
				string input = Console.ReadLine();

				if (input.Length == 0)
					break;

				allNames.Add(input);
			}

			foreach (string name in allNames)
			{
				if (!uniqueNames.Contains(name))
					uniqueNames.Add(name);
			}

			Console.Write("Unique name list contains:");

			foreach (string uniqueName in uniqueNames)
			{
				Console.Write($" {uniqueName}");
			}
		}
	}
}