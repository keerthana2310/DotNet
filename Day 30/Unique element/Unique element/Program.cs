//Write a program in C# Sharp to print all unique elements in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 5, 1, 2, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arr[i] = 0;
                        arr[j] = 0;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
