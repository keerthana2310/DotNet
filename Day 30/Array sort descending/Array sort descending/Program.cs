//Write a C# Sharp program to merge two arrays of the same size sorted in ascending order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sort_descending
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 4, 5 };
            int[] arr2 = { 3, 4, 5 };
            int[] arr3 = arr1.Concat(arr2).ToArray();
            for(int i=0;i<arr3.Length;i++)
            {
                Console.WriteLine(arr3[i]);
            }
            Console.WriteLine("Ascending order");
            Array.Sort(arr3);
            //foreach (int a in arr3)
            //{ Console.WriteLine(a); }
            Console.WriteLine("Descending order");
            Array.Reverse(arr3);
            foreach (int b in arr3)
            { Console.WriteLine(b); }

        }
        


    }
}
