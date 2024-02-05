using System;
using System.Text;

namespace Exercise10
{
	public class RatingManager
	{
		private static Dictionary<string, Rating> ratings = new Dictionary<string, Rating>();

		public void AddNewRating()
		{
			Console.WriteLine("Enter the movie name");
			string name = Console.ReadLine();

			Console.WriteLine($"Give the movie {name} a rating");
			string input = Console.ReadLine();

			if (double.TryParse(input, out double rating))
			{
				if (!ratings.ContainsKey(name))
				{
					ratings.Add(name, new Rating(name));
					ratings[name].ReceiveRating(rating);
				}
				else
				{
					ratings[name].ReceiveRating(rating);
				}
				Console.WriteLine($"Thanks for rating {name} a with {rating} !");
				return;
			}
			Console.WriteLine("You entered invalid name or rating");
		}

		public void ViewRatings()
		{
			foreach (KeyValuePair<string, Rating> rating in ratings)
			{
				rating.Value.DisplayPublicScore();
			}
		}
	}
}