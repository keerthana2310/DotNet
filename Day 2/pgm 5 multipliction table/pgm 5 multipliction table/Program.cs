//Write a C# Sharp program that takes a number as input and print its multiplication table.
using System;


namespace pgm_5_multipliction_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a ;
            Console.WriteLine("Enter a number");
            a=int.Parse(Console.ReadLine());
            
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0}*{1} is {2}",a ,i,a*i);
            }
        }
    }
}
