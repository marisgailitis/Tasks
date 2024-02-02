﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;
            
            Console.WriteLine();

            Car car = new Car(0);
            Car car1 = new Car(0);
            
            for (int i = 0; i < 3; i++)
            {
                FillCar(ref car);
                FillCar(ref car1);
            }

			Calculations calculations = new Calculations();

            Console.WriteLine($"Car Kilometers per liter are {car.CalculateConsumption()} gasHog: {calculations.GasHog(car)}");
            Console.WriteLine($"Car1 Kilometers per liter are {car1.CalculateConsumption()} economyCar: {calculations.EconomyCar(car1)}");
        }

		private static void FillCar(ref Car car)
		{
			Console.Write("Enter first reading: ");
			startKilometers = Convert.ToInt32(Console.ReadLine());  

			Console.Write("Enter liters reading: ");
			liters = Convert.ToInt32(Console.ReadLine());
			
			car.FillUp(startKilometers, liters);
		}
    }
}