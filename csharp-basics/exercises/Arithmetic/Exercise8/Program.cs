﻿using System;

class Program
{
	static void Main(string[] args)
	{
		WorkerPayInfo workerPay = new WorkerPayInfo(8.20, 47);
		double totalPay = CalculateTotalPay(workerPay.basePay, workerPay.hoursWorked);
		Console.WriteLine($"Total pay for a worker with base pay of ${workerPay.basePay} who worked {workerPay.hoursWorked} hours is {totalPay}.");
	}
	private static double CalculateTotalPay(double basePay, double hoursWorked)
	{
		if(hoursWorked > 60 || hoursWorked < 0) throw new ArgumentOutOfRangeException("hoursWorked", "Value must be lower than 60 and non-negative.");
		if(basePay < 8) throw new ArgumentOutOfRangeException("hoursWorked", "Value must be higher than 8 and non-negative.");

		double possibleExtraHours = hoursWorked % 40;

		double totalPay = hoursWorked > 40? 40 * basePay + possibleExtraHours * basePay * 1.5 : possibleExtraHours * basePay;
		return totalPay;
	}
	private struct WorkerPayInfo
	{
		public double basePay;
		public double hoursWorked;

		public WorkerPayInfo(double basePay_, double hoursWorked_)
		{
			basePay = basePay_;
			hoursWorked = hoursWorked_;
		}
	}
}