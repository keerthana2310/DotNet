//Write a C# program to check if "HP" appears at second position in a string and returns the string without "HP
using System;
using System.CodeDom;

namespace string_return_withoutletters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the word");
            string name=Console.ReadLine();
            Console.WriteLine(name.Substring(1));
            Console.WriteLine(name.Remove(1, 2));
        }
    }
}
