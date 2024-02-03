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

			int energyDrinkBuyers = CalculateEnergyDrinkers(NumberedSurveyed);

            Console.WriteLine($"Approximately { energyDrinkBuyers } bought at least one energy drink");
            Console.WriteLine($"{ CalculatePreferCitrus(energyDrinkBuyers) } of those prefer citrus flavored energy drinks.");
        }

        private static int CalculateEnergyDrinkers(int numberSurveyed)
        {
            return (int)(numberSurveyed * PurchasedEnergyDrinks);
        }

        private static int CalculatePreferCitrus(int numberSurveyed)
        {
            return (int)(numberSurveyed * PreferCitrusDrinks);
        }
    }
}