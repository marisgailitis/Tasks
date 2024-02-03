namespace FuelConsumptionCalculator
{
    public class Car
    {
		public double StartKilometers { get; private set; }
		public double EndKilometers { get; private set; }
		public double LitersUsed { get; private set; }
		private Calculations calculations = new Calculations();

        public Car(double startOdo)
        { 
			StartKilometers = startOdo;  
        }

        public void FillUp(int mileage, double liters)
        {
            EndKilometers += mileage;
            LitersUsed += liters;
        }

		public double CalculateConsumption() => calculations.CalculateConsumption(this);

        public double ConsumptionPer100Km() => calculations.ConsumptionPer100Km(this);

        public bool IsGasHog() => calculations.IsGasHog(this);

        public bool IsEconomyCar() => calculations.IsEconomyCar(this);
    }
}