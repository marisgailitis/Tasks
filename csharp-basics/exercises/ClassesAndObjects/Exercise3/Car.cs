using System;
using System.ComponentModel;

namespace Excercise3
{
    public class Car
    {
        public Odometer Odometer { get; private set; }
        public FuelGauge FuelGauge { get; private set; }
		public double FuelAmount { get; private set; }
		public double Mileage { get; private set; }
		public DrivingState State { get; private set; }

		public Car()
		{
			Odometer = new Odometer(this);
            FuelGauge = new FuelGauge(this);
		}

        public async Task Run()
        {
            await FuelGauge.IncreaseFuel();
			FuelGauge.SpendFuel();
			Odometer.Run();
			await Drive();
        }

		public void IncreaseFuel(double multiplier) => ChangeFuelAmount(1 * multiplier * TimeExtensions.DeltaTime);

		public void SpendFuel(double multiplier) => ChangeFuelAmount(-1 * multiplier * TimeExtensions.DeltaTime);
		
		private void ChangeFuelAmount(double amount)
		{
			FuelAmount = Math.Clamp(FuelAmount + amount, 0, 70);
		}

		public void IncreaseMileage(double amount)
		{
			Mileage = Math.Round(Mileage + amount, 2);

			if(Mileage >= 999999)
			{
				Mileage = 0;
			}

			FuelGauge.ReportFuel();
			Odometer.ReportMileage();
		}

		private async Task Drive()
		{
			while(FuelAmount > 0)
			{
				await Task.Delay(TimeExtensions.DeltaMilliSeconds);
			}
		}

        public enum DrivingState 
        { 
            Driving, 
            Filling, 
            Idle
        };
    }
}