namespace Excercise4
{
    public class Movie
	{
		public string Title { get; private set; }
		public string Studio  { get; private set; }
		public string Rating { get; private set; }

		public Movie(string Title_, string Studio_, string Rating_)
		{
			Title = Title_;
			Studio = Studio_;
			Rating = Rating_;
		}

		public Movie(string Title_, string Studio_)
		{
			Title = Title_;
			Studio = Studio_;
			Rating = "PG";
		}
	}
}