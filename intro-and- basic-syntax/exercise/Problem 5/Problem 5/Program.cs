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
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");

            int countOfHealthDots = maximumHealth - currentHealth;

            Console.WriteLine("Health: |{0}{1}|", new string('|', currentHealth), new string('.', countOfHealthDots));


            int countOfPipes = currentEnergy;
            int countOfdots = maximumEnergy - currentEnergy;

            Console.WriteLine("Energy: |{0}{1}|", new string('|', countOfPipes), new string('.', countOfdots));
        }
    }
}
