//Write a C# Sharp program to print the result of dividing two numbers
using System;

namespace pgm2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, divide;
            Console.WriteLine("Enter the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b= int.Parse(Console.ReadLine());
            divide = (a / b);
            Console.WriteLine("result of 2 numbers{0} and {1} is {2}",a,b,divide);
        }
    }
}
