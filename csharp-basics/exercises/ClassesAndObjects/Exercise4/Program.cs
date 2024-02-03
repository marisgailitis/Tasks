using System.Linq;
using System.Net.Mail;

namespace Excercise4
{
    public class Program
    {
        static void Main(string[] args)
        {
			List<Movie> movies = new List<Movie>();
			
			movies.Add(new Movie("Casino Royale", "Eon Productions", "PG­13"));
			movies.Add(new Movie("Glass", "Buena Vista International", "PG­13"));
			movies.Add(new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures"));

			Movie[] pgs = GetPG(movies.ToArray());

			foreach(Movie pg in pgs)
			{
				Console.WriteLine($"{pg.Title} is PG");
			}
		}

		private static Movie[] GetPG(Movie[] movies)
		{
			IEnumerable<Movie> pg = movies.Where(movie => movie.Rating == "PG");
			List<Movie> pgList = new List<Movie>();

			foreach(Movie movie in pg)
			{
				pgList.Add(movie);
			}

			return pgList.ToArray();
		}
    }
}