using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_missing_element_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] arr = { 10, 20,60, 30, 50 };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
              //  Console.WriteLine(arr[i]);
                n = arr[i + 1] - arr[i];
                if (n > 1)
                {
                    Console.WriteLine(arr[i] + 1);
                    break;
                }
            }

           

        }
    }
}
