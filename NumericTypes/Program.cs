using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of rectangle ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter width of rectangle ");
            double width = double.Parse(Console.ReadLine());
            double area = length * width;
            Console.WriteLine($"Area of the rectangle is {area} ");
            Console.ReadLine();
        }
    }
}
