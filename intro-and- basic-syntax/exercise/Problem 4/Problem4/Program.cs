using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            var BeverageName = Console.ReadLine();
            var BeverageVolume = int.Parse(Console.ReadLine());
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());

            var totalCalories = BeverageVolume * energyContent / 100.0;
            var totalSugar = BeverageVolume * sugarContent / 100.0;

            Console.WriteLine($"{BeverageVolume}ml {BeverageName}:");
            Console.WriteLine($"{totalCalories}kcal, {totalSugar}g sugars");
        }
    }
}
