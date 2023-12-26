﻿using System.Reflection.Metadata;

namespace Casting
{
    class CastingMethods
    {
        public void FirstCast()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4;
            float e = 5;

            int sum = int.Parse(a) + b + c + (int)d + (int)e;
            Console.WriteLine(sum);
        }

        public void SecondCast()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            float sum = int.Parse(a) + b + c + (int)d + (int)e;
            Console.WriteLine(sum);
        }
    }
}