using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            int[] arr = new int[5];
            Console.WriteLine("Enter the arrray elements :");
            for (i = 0; i < arr.Length; i++) 
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            //Bubble sort Algorithm
            for( i=0;i<arr.Length-1;i++)
            {
                for (j = 0; j< arr.Length - 1; j++)
                {
                   
                    if (arr[j] > arr[j+ 1])
                    {
                        int t = arr [j];
                        arr[j]=arr[j+ 1];
                        arr[j + 1] = t;

                    }
                }
            }
            Console.WriteLine("now array is");
            for (i = 0;i < arr.Length;i++)
            {
                Console.WriteLine("{0} ", arr[i]);
            }
           
        }
    }
}
