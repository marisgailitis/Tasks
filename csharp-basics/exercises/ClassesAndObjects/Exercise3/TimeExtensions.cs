using System.Diagnostics;

namespace Excercise3
{
	public static class TimeExtensions
	{
		private static long previousTime;
		public static int DeltaMilliSeconds;
		public static double DeltaTime;

		public static async Task Run()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			
			while(true)
			{
				long currentTime = stopwatch.ElapsedMilliseconds;
				DeltaMilliSeconds = (int)(currentTime - previousTime);
				DeltaTime = (double)DeltaMilliSeconds / 1000;
				previousTime = currentTime;

				if (DeltaTime > 0)
				{
					await Task.Delay(DeltaMilliSeconds);
				}
			}
		}
	}
}