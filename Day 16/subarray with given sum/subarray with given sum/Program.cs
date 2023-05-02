using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subarray_with_given_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[]arr= { 1, 4, 20, 3, 10, 5 };
            Console.WriteLine("Enter the value");
            
            int num=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the values in array");
            int[]arr=new int[num];
            for(int i=0; i< num; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the value to compare");
            int sum = int.Parse(Console.ReadLine());
            for(int i=0;i<arr.Length;i++)
            {
                int currentsum = arr[i];

                if (currentsum == sum)
                {
                    Console.WriteLine("Sum found at index" + (i+1));
                    return;
                }
                else
                {
                    for(int j=i+1;j<arr.Length;j++)
                    {
                        currentsum += arr[j];   
                        if (currentsum ==sum)
                        {
                            Console.WriteLine("sum found between indexes "+(i+1)+" "+(j+1));
                            return;
                        }
                    }
                }
            }
            
        }
    }
}
