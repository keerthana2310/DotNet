//Write a C# Sharp program that takes an age (for example 20) as input and prints something as "You look older than 20".
using System;


namespace pgm_6_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age=int.Parse(Console.ReadLine());

            Console.WriteLine("you look older than {0}", age);
        }
    }
}
