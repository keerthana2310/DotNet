//Write a C# Sharp program to swap two numbers
using System;
using System.CodeDom.Compiler;

namespace pgm_3_swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, temp;
            Console.WriteLine("Enter the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = int.Parse(Console.ReadLine());
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping");
            Console.WriteLine("first number is "+ a);
            Console.WriteLine("second number is "+ b);
            //without using temp

            int x = 50;
            int y = 20;
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("After swapping {0} {1}", x, y);


        }
    }
}
