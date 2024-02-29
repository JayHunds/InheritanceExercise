using System;
using System.Data.SqlTypes;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird
            {
                Species = "Parrot",
                Age = 5,
                Habitat = "Tropical forests",
                IsVertebrate = true,
                FeatherColor = "Green",
                CanFly = true,
                Sound = "Squawk",
                HasBeak = true
            };

            Console.WriteLine("Bird: ");
            Console.WriteLine($"Species: {bird.Species}");
            Console.WriteLine($"Age: {bird.Age}");
            Console.WriteLine($"Habitat: {bird.Habitat}");
            Console.WriteLine($"Is Vertebrate: {bird.IsVertebrate}");
            Console.WriteLine($"Feather Color: {bird.FeatherColor}");
            Console.WriteLine($"Can Fly: {bird.CanFly}");
            Console.WriteLine($"Sound: {bird.Sound}");
            Console.WriteLine($"Has Beak: {bird.HasBeak}");

            Reptile reptile = new Reptile
            {
                Species = "Snake",
                Age = 3,
                Habitat = "Desert",
                IsVertebrate = true,
                IsColdBlooded = true,
                HasScales = true,
                LaysEggs = true,
                SkinTexture = "Smooth"
            };
            Console.WriteLine("\nReptile:");
            Console.WriteLine($"Species: {reptile.Species}");
            Console.WriteLine($"Age: {reptile.Age}");
            Console.WriteLine($"Habitat: {reptile.Habitat}");
            Console.WriteLine($"Is Vertebrate: {reptile.IsVertebrate}");
            Console.WriteLine($"Is Cold Blooded: {reptile.IsColdBlooded}");
            Console.WriteLine($"Has Scales: {reptile.HasScales}");
            Console.WriteLine($"Lays Eggs: {reptile.LaysEggs}");
            Console.WriteLine($"Skin Texture: {reptile.SkinTexture}");
        }

    }
}
