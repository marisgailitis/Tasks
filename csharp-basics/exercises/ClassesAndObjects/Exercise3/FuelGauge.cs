using System;

namespace Excercise3
{
	public class FuelGauge
	{
		private Car car;
		private double speedMultiplier = 5;

		public FuelGauge(Car car_)
		{
			car = car_;
		}

		public async Task IncreaseFuel()
		{
			while (car.FuelAmount < 70)
			{
				car.IncreaseFuel(speedMultiplier);
				ReportFuel();
				await Task.Delay(TimeMethods.DeltaMilliSeconds);
			}
		}

		public async Task SpendFuel()
		{
			while (car.FuelAmount > 0)
			{
				car.SpendFuel(speedMultiplier);
				ReportFuel();
				await Task.Delay(TimeMethods.DeltaMilliSeconds);
			}
		}

		public void ReportFuel()
		{
			Console.WriteLine($"The current amount of fuel left is {Math.Round(car.FuelAmount, 2)}");
		}
	}
}