﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duplicate_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 1, 2, 3, 5, 3 };
            for(int i=0;i<a.Length; i++)
            {
                for(int j=i+1;j<a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        Console.WriteLine(a[i]);
                    }
                }
            }

        }
    }
}
