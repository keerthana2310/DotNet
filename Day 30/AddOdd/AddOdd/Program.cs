//Write a program to read an integer and find the sum of all odd numbers from 1 to the given number. [inclusive of the given number] if N = 9[1, 3, 5, 7, 9].Sum = 25
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the integer");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=0;i<=n;i++)
            {
                if(i%2!=0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
