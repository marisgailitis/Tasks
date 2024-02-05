namespace Excercise3
{
	public class Program
	{
		static async Task Main(string[] args)
		{
			TimeExtensions.Run();
			await SpawnCar();
		}

		private static async Task SpawnCar()
		{
			Car car = new Car();
			await car.Run();
		}
	}
}