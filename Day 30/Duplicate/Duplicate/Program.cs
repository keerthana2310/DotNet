﻿//Write a C# Sharp program in to count duplicate elements in an array.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int[] a = new int[5];
            Console.WriteLine("No.of elements in an array");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
                
            for(int i=0;i<a.Length;i++)
            {
                for(int j=i+1;j<a.Length;j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Duplicate elements are:" +count);

        }
    }
}
