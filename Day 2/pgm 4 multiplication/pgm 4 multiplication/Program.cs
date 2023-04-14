//Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
using System;


namespace pgm_4_multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the first number");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            c=int.Parse(Console.ReadLine());
            Console.WriteLine("output is  "+a * b * c);

        }
    }
}
