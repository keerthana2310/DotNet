//Write a program in C# Sharp to print individual characters of the string in reverse order
using System;
using System.Web;

namespace pgm_11_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the string");
            string name = Console.ReadLine();
            int l = name.Length - 1;

            while (l >= 0)
            {
                Console.Write("After reversing:{0}", name[l]);
                l--;


            }
        }
    }
}
