using System;
using System.Text;

namespace Exercise10
{
    public class VideoStore
    {
		private List<Video> videos = new List<Video>();
		
		public void AddVideo(string name)
		{
			videos.Add(new Video(name));
		}

		public bool CheckOutVideo(string name)
		{
			foreach(Video video in videos)
			{
				if(video.Title == name && !video.CheckedOut)
				{
					video.GetCheckedOut();
					Console.WriteLine($"You have checked out a {video.Title}");

					if(name == "Godfather II")
					{
						ListInventory();
					}
					return true;
				}
			}
			Console.WriteLine("All the videos of this type have are currently rented out");

			return false;
		}

		public bool ReturnVideo(string name)
		{
			foreach(Video video in videos)
			{
				if(video.Title == name && video.CheckedOut)
				{
					video.GetReturned();
					return true;
				}
			}
			Console.WriteLine("All the videos of this type have already been returned");

			return false;
		}

		public void ListInventory()
		{
			StringBuilder builder = new StringBuilder();
			builder.Append($"We have more, the amount of movies we have is { videos.Count }: ");

			Dictionary<string, int> videoCount = new Dictionary<string, int>();

			foreach(Video video in videos)
			{
				string title = video.Title;
				if(!videoCount.ContainsKey(title))
				{
					videoCount.Add(title, 1);
				}
				else
				{
					videoCount[title] += 1;
				}
			}
			foreach(KeyValuePair<string, int> count in videoCount)
			{
				builder.Append($"{count.Key} : {count.Value}, ");
			}
			Console.WriteLine(builder.ToString());
		}
    }
}