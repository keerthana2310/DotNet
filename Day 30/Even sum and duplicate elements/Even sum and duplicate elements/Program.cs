//Write a program to read a integer array, Remove the duplicate elements and display sum of even numbers in the output. If input array contain only odd number then return -1.
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_sum_and_duplicate_elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int sum = 0;
            for (int i = 0; i < a.Length; i++)

            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int[] b = new int[10];
            //a = a.Distinct().ToArray();
            //foreach (int item in a)
            //{
            //    Console.WriteLine(item);
            //}
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        a[i] = 0;
                    }


                }
            }
            Console.WriteLine("Duplicate");
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                    Console.WriteLine(a[i]);

            }
            Console.WriteLine("Even");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum += a[i];
                }


            }
            Console.WriteLine(sum);
            Console.WriteLine("odd");
            if (sum == 0)
            {
                Console.WriteLine(-1);
            }
            int s = Convert.ToInt32(Console.ReadLine());

            //    int sum = 0, c = 0, op = 0;

            //    int[] a= new int[s];

            //    int[] b= new int[s];

            //    for (int i = 0; i < s; i++)
            //    {
            //        a[i] = Convert.ToInt32(Console.ReadLine());

            //        if (a[i] % 2 != 0)
            //        {
            //            c++;
            //        }
            //    }

            //    if (c == s)
            //    {
            //        op = -1;
            //        Console.WriteLine(op);
            //        return;
            //    }

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        for (int j = 0; j < a.Length; j++)
            //        {
            //            if (a[i] != a[j])
            //            {
            //                b[i] = a[i];
            //            }
            //        }
            //    }

            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        if (b[i] % 2 == 0)
            //        {
            //            sum += b[i];
            //        }
            //    }

            //    Console.WriteLine(sum);
        }
    }
}

