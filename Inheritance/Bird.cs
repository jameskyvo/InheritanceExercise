using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool HasFlight;
        public string SoundofChirp;
        public string LengthofBeak;
        public bool StaysWithEggs;

        public void DisplayInformation(string flightOutput, string eggOutput)
        {
            Console.WriteLine($"This bird lives for {Lifespan} years. It has {NumberofLegs} legs and is a {Size} {MovementSpeed} creature. It {flightOutput}. ");
            Console.WriteLine($"It has a {LengthofBeak} beak, and {eggOutput}. It goes {SoundofChirp}.\n");
        }
    }
}
