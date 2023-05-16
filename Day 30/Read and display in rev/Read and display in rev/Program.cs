//Write a C# Sharp program to read n values in an array and display them in reverse order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_and_display_in_rev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 3, 4, 5 };
            //for(int i=0;i<arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            int[] arr = new int[5];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            //for (int i=0;i<arr.Length;i++)
            //{
            //   Console.WriteLine(arr[i]);
            //}
            
            Console.WriteLine("after reversing");
            for(int i=arr.Length-1;i>=0;i--)
            {
                Console.WriteLine(arr[i]);
            }


        }
    }
}
