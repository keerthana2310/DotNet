//Write a program in C# Sharp to find the positive numbers from a list of numbers using two where conditions in LINQ Query.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { -3, 4,3, 20, -5, -7, 43 };
            var query=from i in a
                      where i>0
                      where i<45
                      select i;
            foreach(var n in query)
            {
                Console.WriteLine(n);
            }
        }
    }
}
