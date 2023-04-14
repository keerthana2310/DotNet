//Write a C# program that takes a number as input and then displays a rectangle of 3 columns wide and 5 rows tall using that digit
using System;


namespace pgm8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", num);
            Console.WriteLine("{0}{0}", num);
            Console.WriteLine("{0}{0}", num);
            Console.WriteLine("{0}{0}", num);
            Console.WriteLine("{0}{0}{0}", num);
           
        }
    }
}
