using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            double m = double.Parse(Console.ReadLine());
            double km = m * 1.60934;
            Console.WriteLine($"{km:f2}");
        }
    }
}
