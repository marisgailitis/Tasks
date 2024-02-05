namespace FuelConsumptionCalculator
{
	public class Calculations
	{
		public double CalculateConsumption(Car car)
		{
			return car.LitersUsed / (car.EndKilometers - car.StartKilometers);
		}

		public double ConsumptionPer100Km(Car car)
		{
			return CalculateConsumption(car) * 100;
		}

		public bool IsGasHog(Car car)
		{
			return ConsumptionPer100Km(car) > 15;
		}

		public bool IsEconomyCar(Car car)
		{
			return ConsumptionPer100Km(car) < 5;
		}
	}
}