//Confirmed from Mu7k0
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            //We recieve from the Console parts of the debit card number (as integers)
            //Mu7k0 cannot change the variable for this problem
            int firstPart = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourth = int.Parse(Console.ReadLine());
            //Printing DebitCard number(as string)
            Console.WriteLine($"{firstPart:D4} {second:D4} {third:D4} {fourth:d4}");

        }
    }
}
