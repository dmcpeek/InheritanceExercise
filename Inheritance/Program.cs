using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done - Create a class Animal
            // Done - give this class 4 members that all Animals have in common

            // Done - Create a class Bird
            // Done - give this class 4 members that are specific to Bird
            // Done - Set this class to inherit from your Animal Class

            // Done - Create a class Reptile
            // Done - give this class 4 members that are specific to Reptile
            // Done - Set this class to inherit from your Animal Class

            /* Done - Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var ostrich = new Bird();
            ostrich.hasFeathers = true;
            ostrich.canFly = false;
            ostrich.doesMigrate = false;
            ostrich.eatsSeeds = false;

            var feathers = (ostrich.hasFeathers) ? "mostly brown feathers" : "colorful feathers";
            var flies = (ostrich.canFly) ? "fly very fast" : "run very fast";
            var migrates = (ostrich.doesMigrate) ? "go south to it's winter home" : "don't go south for the winter";
            var food = (ostrich.eatsSeeds) ? "seeds and bugs" : "Purina Ostrich Chow";

            Console.WriteLine("My neighbor Jim-Bob raises ostriches.");
            Console.WriteLine($"I've noticed that they have {feathers}.");
            Console.WriteLine($"He told me they {flies}. I don't believe him though.");
            Console.WriteLine($"I've read that they {migrates}.");
            Console.WriteLine($"Jim-Bob feeds them {food}.");
            /*Done - Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var rhinoViper = new Reptile();
            rhinoViper.hasScales = true;
            rhinoViper.isVenomous = true;
            rhinoViper.hasForkedTongue = true;
            rhinoViper.isArboreal = false;

            var scales = (rhinoViper.hasScales) ? "keeled scales" : "smooth scales";
            var venom = (rhinoViper.isVenomous) ? "lethal" : "harmless";
            var tongue = (rhinoViper.hasForkedTongue) ? "sinister looking tongue" : "peaceful lookingg tongue";
            var trees = (rhinoViper.isArboreal) ? "lives high in trees" : "lives on the ground";
            Console.WriteLine();
            Console.WriteLine("The Denver Zoo has a mated pair of Rhino Vipers.");
            Console.WriteLine($"When I handled one I noticed that it has {scales}.");
            Console.WriteLine($"I was told it is {venom}. I handled it appropriately.");
            Console.WriteLine($"I didn't get too close but I noticed it has a {tongue}.");
            Console.WriteLine($"It {trees}.");
        }
    }
}
