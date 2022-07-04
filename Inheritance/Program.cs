using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var weaver = new Bird() 
            { HasFlight = true, SoundofChirp = "chirp chirp chirp", LengthofBeak = "relatively large", StaysWithEggs = true, Lifespan = 15, MovementSpeed = "fast", NumberofLegs= 2, Size = "small"};
            string weaverFlightOutput = weaver.HasFlight ? "has the ability to fly" : "can not fly";
            string weaverEggOutput = weaver.StaysWithEggs ? "is a good parent that stays with their eggs" : "left to get milk and never came back";
            weaver.DisplayInformation(weaverFlightOutput, weaverEggOutput);




            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var komodoDragon = new Reptile()
            { ColorofScales = "gray", IsLazy = true, LaysEggsInWater = false, LengthofTail = 2, Lifespan = 30, MovementSpeed = "slow", NumberofLegs = 4, Size = "large and in charge" };
            string dragonLazyOutput = komodoDragon.IsLazy ? "is a lazy creature that wants to sun all day" : "likes to get things done.";
            string dragonEggOutput = komodoDragon.IsLazy ? "lays their eggs in water" : "lays their eggs on land.";
            komodoDragon.DisplayInformation(dragonLazyOutput, dragonEggOutput);

        }
    }
}
