//CONFIRMED from Mu7k0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1_23jan18
{
    class Program
    {
        static void Main(string[] args)
        {
            // We recieve from the Console widht and height -> a double;
            double widht = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            //We find rectangle area by multiplying widht by height;
            double area = widht * height;

            //Print area;
            //Result is rounded to the second digit after floating point;
            Console.WriteLine($"{area:f2}");
        }
    }
}
