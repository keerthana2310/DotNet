//Write a program in C# Sharp to display the number and frequency of a given number from an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Enter the number");
           // int num=int.Parse(Console.ReadLine());
            int[]num=new int[] { 3, 3, 4, 6, 7, 5, 4, 5, 8 };
            var query = from i in num
                        group i by i into a
                        select a;
            foreach(var i in query)
            {
                Console.WriteLine(i.Key+i.Count());
            }
        }
    }
}
