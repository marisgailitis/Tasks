namespace FuelConsumptionCalculator
{
    public class Car
    {
		private double startKilometers; // Starting odometer reading
		private double endKilometers; // Ending odometer reading
		private double litersUsed;

        public Car(double startOdo)
        { 
			startKilometers = startOdo;  
        }

        public void FillUp(int mileage, double liters)
        {
            startKilometers += endKilometers;
            endKilometers = mileage;
            litersUsed += liters;
        }
    }
}