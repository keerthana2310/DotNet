//Calculate area of circle
using System;

namespace circle_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = 0,area;
            Console.WriteLine("Enter the radius");
            radius=double.Parse(Console.ReadLine());
            area = circle_area(radius);
            Console.WriteLine("Area of circle having radius{0} is{1}", radius, area);
           

        }
static double circle_area(double r)
        { double area = 0;
            area = 3.14 * r * r;
                return area; }
    }
}
