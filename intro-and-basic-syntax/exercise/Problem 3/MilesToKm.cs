using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            // We receive from the console value in miles -> double;
            double m = double.Parse(Console.ReadLine());
            // We calculate km
            double km = m * 1.60934;
            // TODO
            Console.WriteLine($"{km:f2}");
        }
    }
}