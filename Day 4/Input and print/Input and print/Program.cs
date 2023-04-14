//Write a program in C# Sharp to input a string and print it.
using System;


namespace Input_and_print
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter the string");
            string x = Console.ReadLine();
            Console.WriteLine("String is" + x);
        }
    }
}
