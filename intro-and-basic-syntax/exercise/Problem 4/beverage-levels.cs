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
            var product = Console.ReadLine();

            //In the next 3 lines we receive volume, energy and sugar content of our products
            var volume = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());

            //We calculate....
            double totalEnergy = energyPer100ml / 100.0 * volume;
            double totalSugar = sugarPer100ml * volume / 100.0;

            //TODO
            Console.WriteLine("{0}ml {1}:", volume, product);
            Console.WriteLine("{0}kcal, {1}g sugars", totalEnergy, totalSugar);
        }
    }
}