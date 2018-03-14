using System;

namespace Miles_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Confirmed by vallecbg

            // We receive from the console value in miles -> double;
            double miles = double.Parse(Console.ReadLine());
            // We calculate km
            double kilometers = miles * 1.60934;
            // TODO
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}