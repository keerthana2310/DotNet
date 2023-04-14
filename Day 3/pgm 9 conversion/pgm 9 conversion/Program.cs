//Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit
using System;


namespace pgm_9_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the celcius value");
            int celcius = int.Parse(Console.ReadLine());
            Console.WriteLine("kelvin={0}", celcius + 273);
            Console.WriteLine("Farenheit={0}", celcius * 18 / 10 + 32);
        }
    }
}
