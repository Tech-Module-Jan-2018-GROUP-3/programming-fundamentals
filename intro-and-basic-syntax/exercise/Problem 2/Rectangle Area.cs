using System;


namespace rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            // So we need to calculate the rectangle's area
            // We need to get some items:

            // We receive from the Console the rectangle's width -> a double;
            double width = double.Parse(Console.ReadLine());
            // We height from the Console the rectangle's width -> a double;
            double height = double.Parse(Console.ReadLine());
            /* We need to calculate the rectangle's area
             Sample - We receive:
             Width: 2
             Height: 7
             Area: Width * Height = 2 * 7 = 14
              */
            // Also, we need to make the area to double because we are multiplying floating point numbers
            double area = width * height;
            // In the end, we print the area on the Console, rounded to the 2nd character after the decimal point.
            Console.WriteLine("{0:f2}", area);
        }
    }
}
