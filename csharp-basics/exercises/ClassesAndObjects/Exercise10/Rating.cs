using System;
using System.Text;

namespace Exercise10
{
	public class Rating
	{
		public string Title { get; private set; }
		public int TotalRated { get; private set; }
		public int TotalLiked { get; private set; }
		public double CurrentScore { get; private set; }
		private List<double> scores = new List<double>();

		public Rating(string title)
		{
			Title = title;
		}

		public void ReceiveRating(double rating)
		{
			Console.WriteLine(rating);
			CalculateCurrentScore(rating);
			GetLikePercentage();
		}

		public void DisplayPublicScore()
		{
			Console.WriteLine($"The customer ratings for {Title} is {CurrentScore} and was liked by {GetLikePercentage()} percent of viewers");
		}

		private void CalculateCurrentScore(double rating)
		{
			double roundedRating = Math.Round(Math.Clamp(rating, 0, 10), 2);
			scores.Add(roundedRating);

			TotalRated++;

			if (rating >= 7)
			{
				TotalLiked++;
			}
			CurrentScore = 0;
			int ratingCount = scores.Count;
			foreach (double score in scores)
			{
				CurrentScore += score;
			}
			CurrentScore /= ratingCount;
		}

		private double GetLikePercentage()
		{
			return Math.Round((double)TotalLiked / (double)TotalRated * 100);
		}
	}
}