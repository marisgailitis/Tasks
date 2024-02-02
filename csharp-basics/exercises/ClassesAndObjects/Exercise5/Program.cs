﻿using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);

			double energyDrinkBuyers = CalculateEnergyDrinkers(NumberedSurveyed);

            Console.WriteLine($"Approximately { energyDrinkBuyers } bought at least one energy drink");
            Console.WriteLine($"{ CalculatePreferCitrus((int)(energyDrinkBuyers * PreferCitrusDrinks)) } of those prefer citrus flavored energy drinks.");
        }

        private static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return Math.Floor((double)numberSurveyed * PurchasedEnergyDrinks);
        }

        private static double CalculatePreferCitrus(int numberSurveyed)
        {
            return Math.Floor((double)numberSurveyed * PreferCitrusDrinks);
        }
    }
}