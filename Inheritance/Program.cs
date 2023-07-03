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

            Bird chicken1 = new Bird() { CanFly = false, NumOfLegs = 2, HasToes = true, FeatherColor = "Brown", };
            int numToes = chicken1.NumOfToes(3);
            Bird.WingSpan span = 0;
            Bird.BeakType beakType = 0;

            Console.WriteLine($"Often we get asked, can chickens fly? \nThe answer has always been, {chicken1.CanFly}. \nThey are flightless birds. Aka, birds that aren't really birds. They" +
                $" have a {span} wing span that cannot carry their weight. However, they do have {chicken1.NumOfLegs} legs with {numToes} toes on each. Their feathers are " +
                $"typically {chicken1.FeatherColor} and their beaks air fairly {beakType}.");

            /*
             * Created an alien chicken to show that HasToes and numToes functions properly
            */

            Console.WriteLine();

            Bird alienChicken = new Bird() { CanFly = true, NumOfLegs = 6, HasToes = false, FeatherColor = "Neon-Green" };
            int alienNumToes = alienChicken.NumOfToes(1000);
            Bird.WingSpan alienSpan = Bird.WingSpan.Massive;
            Bird.BeakType alienBeak = Bird.BeakType.Curved;

            Console.WriteLine($"This species of chicken has {alienChicken.NumOfLegs} legs, but {alienNumToes} toes on each leg. Strange, is it not? " +
                $"\nIt's features are an unnatural {alienChicken.FeatherColor}, its beak {alienBeak} and its wingspan {alienSpan}. \nWhich begs the question: Can it fly? \n" +
                $"The answer. \n{alienChicken.CanFly}\nHow very bizarre.");

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile gecko = new Reptile() { ScaleColor = "Teal", CanCamo = true, CanSwim = true, HasScales = true, NumOfLegs = 4, HasToes = true };
            int gToes = gecko.NumOfToes(5);
            Animal.TailLength gTailLength = Animal.TailLength.Long;

            Console.WriteLine($"A gecko is a curious creature with many different abilites. It's {gecko.CanSwim} that they can swim, it's {gecko.CanCamo} that they can camoflauge and it's" +
                $" true that they are cold blooded. This particular gecko also has a color not found very often amoung its species: {gecko.ScaleColor}. They typically have " +
                $"{gecko.NumOfLegs} legs with {gToes} toes on each. A truly marvelous creature with a rather {gTailLength} tail compared to its size.");

        }
    }
}
