//Write a program in C# Sharp to find the sum of all array elements.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sum = 0;
            //int[] arr = { 2, 10, 7, 6, 13 };
            //for(int i=0; i<arr.Length; i++)
            //{
            //  sum += arr[i];

            //}
            //Console.WriteLine("sum of array is" + sum);
            int sum = 0;
            int[]a=new int[10];

            for(int i=0; i<a.Length; i++)
            {
                a[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum);
        }
    }
}
