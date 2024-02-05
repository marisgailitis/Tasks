using System;
﻿using System.IO;

namespace Exercise6
{
    class Program
    {
		private static Dictionary<string, List<string>> destinations = new Dictionary<string, List<string>>();

        static void Main(string[] args)
        {
			while(true)
			{
				Console.WriteLine($"What would you like to do? To view travel destinations, press 1, to exit program, press #");
				ConsoleKeyInfo keyPressed = Console.ReadKey();

				if(keyPressed.KeyChar == '#')
					break;

				if(keyPressed.KeyChar == '1')
				{
					Console.WriteLine();
					InitializeTravelLocations();

					foreach(KeyValuePair<string, List<string>> destination in destinations)
						foreach(string travel in destination.Value)
							Console.WriteLine($"From {destination.Key} travel to {travel}");
					
					GetStartingLocation();
				}
				
			}
        }

		private static void GetStartingLocation()
		{
			Console.WriteLine();
			Console.WriteLine("Select the starting location by typing in the city name");
			string input = Console.ReadLine();

			Travel(input);
		}

		private static void Travel(string startingLocation)
		{
			string pickedLocation = startingLocation;

			while(true)
			{
				bool locationPicked = false;

				foreach(string location in destinations[pickedLocation])
				{
					Console.WriteLine(location);
				}
				Console.WriteLine("Type the name of the location you wish to travel to");
				string input = Console.ReadLine();

				if(destinations[pickedLocation].Contains(input))
				{
					pickedLocation = input;
					locationPicked = true;
				}

				if(pickedLocation == startingLocation && locationPicked)
				{
					Console.WriteLine("We hope you enjoyed the travel! Have a nice day!");
					Environment.Exit(0);
				}
			}
		}

		private static void InitializeTravelLocations()
		{
			using (StreamReader sr = new StreamReader("flights.txt"))
            {
                string line;

				while ((line = sr.ReadLine()) != null)
                {
                    string[] separatedLine = line.Split(" -> ");

					if(!destinations.ContainsKey(separatedLine[0]))
					{
						destinations.Add(separatedLine[0], new List<string>(){ separatedLine[1] });
					}
					else
					{
						destinations[separatedLine[0]].Add(separatedLine[1]);
					}
                }
            }
		}
    }
}