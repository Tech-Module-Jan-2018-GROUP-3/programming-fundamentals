using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // We receive from the Console the product name
            var productName = Console.ReadLine();

            //In the next 3 lines we receive volume, energy and sugar content of our products
            var productVolume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugar = int.Parse(Console.ReadLine());

            //We calculate....
            double energyTotal = energy / 100.0 * productVolume;
            double sugarTotal = sugar * productVolume / 100.0;

            //TODO
            Console.WriteLine("{0}ml {1}:", productVolume, productName);
            Console.WriteLine("{0}kcal, {1}g sugars", energyTotal, sugarTotal);
        }
    }
}