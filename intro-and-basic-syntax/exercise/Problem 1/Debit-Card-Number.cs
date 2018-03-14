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
            // We receive from the Console 4 integers 
            var firstNum = int.Parse(Console.ReadLine());
            var SecondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());
            var fourthNum = int.Parse(Console.ReadLine());

            // Print them in 4-digit debit card format 
            Console.WriteLine("{0} {1} {2} {3}", firstNum.ToString("D4"),
                SecondNum.ToString("D4"),
                thirdNum.ToString("D4"),
                fourthNum.ToString("D4"));
        }
    }
}