using System;
using MoreVariablesAndPrinting;

class Program
{
    static void Main(string[] args)
    {
        string name = "Zed A. Shaw";
        double age = 35;
        double height = 74;
        double weight = 180;
        string eyeColor = "Blue";
        string teethColor = "White";
        string hairColor = "Brown";
        PersonCharacteristics zedaShawCharacteristics = new PersonCharacteristics(name, age, height, weight, eyeColor, teethColor, hairColor);
        zedaShawCharacteristics.DebugCharacteristics();

        Console.Read();
    }
}