using System;

namespace MoreVariablesAndPrinting
{
    class PersonCharacteristics
    {
        private string name, eyeColor, teethColor, hairColor;
        private double age, height, weight;

        public PersonCharacteristics (string name_, double age_, double heightInInches, double weightInPounds, string eyeColor_, string teethColor_, string hairColor_)
        {
            name = name_;
            age = Double.Round(age_, 2);
            height = Double.Round(heightInInches * 2.54, 2);
            weight = Double.Round(weightInPounds * 0.453592, 2);
            eyeColor = eyeColor_;
            teethColor = teethColor_;
            hairColor = hairColor_;
        }

        public void DebugCharacteristics()
        {
            Console.WriteLine($"Let's talk about {name}.");
            Console.WriteLine($"He's {height} centimeters tall.");
            Console.WriteLine($"He's {weight} kilograms heavy.");
            Console.WriteLine($"Actually, that's not too heavy.");
            Console.WriteLine($"He's got {eyeColor} eyes and {hairColor} hair.");
            Console.WriteLine($"His teeth are usually {teethColor} depending on the coffee.");
            Console.WriteLine($"If I add {age}, {height}, and {weight} I get {age + height + weight}.");
        }
    }
}