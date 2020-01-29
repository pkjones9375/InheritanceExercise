using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var parakeet = new Bird();
            parakeet.HasButt = true;
            parakeet.HasMouth = true;
            parakeet.InZoos = true;
            parakeet.IsAlive = true;
            parakeet.HasWings = true;
            parakeet.AreDelicious = "If prepared correctly";
            parakeet.GoodPets = "Absolutely not";
            parakeet.NumOfWings = 2;

            var snek = new Reptile();
            snek.HasButt = false;
            snek.NumberOfSoulsPerReptile = 0;
            snek.HasMouth = true;
            snek.InZoos = true;
            snek.RobotOfAnimalKingdom = true;
            snek.IsAlive = true;
            snek.AreGoodPets = "If you're a psycho person";
            snek.Delicious = "Can vouch that rattlesnake is indeed delicious";

            Console.WriteLine($"Are snakes good pets? {snek.AreGoodPets}");
            Console.WriteLine($"Snakes are in zoos, true or false? {snek.InZoos}");
            Console.WriteLine($"Are parakeets good to eat? {parakeet.AreDelicious}");
            


            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }// TODO Be sure to follow best practice when creating your classes

    // Create a class Animal
    // give this class 4 members that all Animals have in common


    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class

    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class

}
