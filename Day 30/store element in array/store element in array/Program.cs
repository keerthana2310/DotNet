//Write a C# Sharp program that stores elements in an array and prints them
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_element_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[]arr=new int[10];

            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                

            }
            
            //for(int i=0; i<arr.Length ; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

        }
    }
}
