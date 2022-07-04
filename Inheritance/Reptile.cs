using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsLazy;
        public bool LaysEggsInWater;
        public string ColorofScales;
        public int LengthofTail;

        public void DisplayInformation(string lazyOutput, string eggOutput)
        {
            Console.WriteLine($"This reptile lives for {Lifespan} years. It has {NumberofLegs} legs and is a {MovementSpeed} creature. It {lazyOutput}.");
            Console.WriteLine($"Its scales are {ColorofScales}. It {eggOutput}, and has a tail that is {LengthofTail} feet long.\n");
        }
    }
}