using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int healthMax = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int energyMax = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            int healthDotsCount = healthMax - health;

            Console.WriteLine("Health: |{0}{1}|", new string('|', health), new string('.', healthDotsCount));


            int countOfPipes = energy;
            int countOfdots = energyMax - energy;

            Console.WriteLine("Energy: |{0}{1}|", new string('|', countOfPipes), new string('.', countOfdots));
        }
    }
}
