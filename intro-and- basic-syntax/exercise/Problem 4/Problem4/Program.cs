using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugarcontent = int.Parse(Console.ReadLine());

            var calories = volume * energy / 100.0;
            var sugar = volume * sugarcontent / 100.0;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{calories}kcal, {sugar}g sugars");
        }
    }
}
