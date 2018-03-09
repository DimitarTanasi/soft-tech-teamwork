using System;

class MilesToKilometers
{
    static void Main(string[] args)
    {
		// Receive distance in miles from Console
        double miles = double.Parse(Console.ReadLine());
		// Convert miles to kilometers
        double kilometers = miles * 1.60934;
		//TODO...
        Console.WriteLine($"{kilometers:f2}");
    }
}
