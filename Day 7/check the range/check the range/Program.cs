//Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_the_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(((a >= -10 && a <= 10)) || (b >= -10 && b >= 10));
        }
    }
}
