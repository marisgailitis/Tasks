using System;
using VariablesAndNames;

class Program
{
    private static void Main(string[] args)
    {
        CarServiceCapability carServiceCapability = new CarServiceCapability(100, 4, 28, 90);
        carServiceCapability.GetCurrentServiceInfo();
        carServiceCapability.WriteCurrentServiceInfo();
        Console.Read();
    }
}