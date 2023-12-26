using System;

namespace VariablesAndNames
{
    class CarServiceCapability
    {
        private int cars, seatsInOneCar, drivers, passengers;
        private int carsNotDriven, carpoolCapacity;
        private double averagePassengersPerCar;

        public CarServiceCapability(int cars_, int seatsInOneCar_, int drivers_, int passengers_)
        {
            cars = cars_;
            seatsInOneCar = seatsInOneCar_;
            drivers = drivers_;
            passengers = passengers_;
        }

        public void GetCurrentServiceInfo()
        {
            carsNotDriven = cars - drivers;
            int maxPassengersPerCar = seatsInOneCar - 1;
            carpoolCapacity = maxPassengersPerCar * drivers;
            averagePassengersPerCar = Double.Round((double)passengers / (double)drivers, 2);
        }

        public void WriteCurrentServiceInfo()
        {
            Console.WriteLine($"There are {cars} cars available.");
            Console.WriteLine($"There are only {drivers} drivers available.");
            Console.WriteLine($"There will be {carsNotDriven} empty cars today.");
            Console.WriteLine($"We can transport {carpoolCapacity} people today.");
            Console.WriteLine($"We have {passengers} passengers to carpool today.");
            Console.WriteLine($"We need to put about {averagePassengersPerCar} in each car.");
        }
    }
}