using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 6, 13, 60, 73 };
            // Console.WriteLine( a.Max());
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
