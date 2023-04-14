//Write a C# program remove specified a character from a non-empty string using index of a character.
using System;


namespace pgm_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string phrase = "paru";
            Console.WriteLine(phrase.Remove(1,2));
        }
    }
}
