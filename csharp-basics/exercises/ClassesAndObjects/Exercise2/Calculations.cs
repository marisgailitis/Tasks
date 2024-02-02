namespace FuelConsumptionCalculator
{
    public class Calculations
    {
		public double CalculateConsumption(Car car)
        {
            return (car.endKilometers - car.startKilometers) / car.litersUsed;
        }

        private double ConsumptionPer100Km(Car car)
        {
            return CalculateConsumption(Car car) * 100;
        }

        public bool GasHog(Car car)
        {
           return ConsumptionPer100Km(car) > 15;
        }

        public bool EconomyCar(Car car)
        {
            return ConsumptionPer100Km(car) < 5;
        }
    }
}