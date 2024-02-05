using System;

namespace Excercise3
{
	public class Odometer
	{
		private Car car;
		private double speedMultiplier = 50;

		public Odometer(Car car_)
		{
			car = car_;
		}

		public async Task Run()
		{
			while (car.State == Car.DrivingState.Driving)
			{
				car.IncreaseMileage(TimeMethods.DeltaTime * speedMultiplier);
				await Task.Delay(TimeMethods.DeltaMilliSeconds);
			}
		}

		public void ReportMileage()
		{
			Console.WriteLine($"The current mileage on the odometer is {Math.Round(car.Mileage, 2)}");
		}
	}
}