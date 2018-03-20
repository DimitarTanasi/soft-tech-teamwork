//CONFIRMED from margaritov
using System;

namespace Problem4
{
    class Program
    {
        static void Main(string[] args)
        {
			// We receive beverage name and volume from the console
            var BeverageName = Console.ReadLine();
            var BeverageVolume = int.Parse(Console.ReadLine());
			//We receive energy and sugar data
            var energyContent = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());
			
			// We calculate  energy and sugar contained in beverage
            var totalCalories = BeverageVolume * energyContent / 100.0;
            var totalSugar = BeverageVolume * sugarContent / 100.0;

			// We print calculated data to the console 
            Console.WriteLine($"{BeverageVolume}ml {BeverageName}:");
            Console.WriteLine($"{totalCalories}kcal, {totalSugar}g sugars");
        }
    }
}
