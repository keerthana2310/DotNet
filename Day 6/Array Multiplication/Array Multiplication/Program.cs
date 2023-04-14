//Write a C# program to multiply corresponding elements of two arrays of integers
using System;


namespace Array_Multiplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstarray = { 1, 2, 4, 5 };
            int[] secondarray = { 4, 5, 6, 7, 9 };
            Console.WriteLine("Multiply elements of two array");
            for (int i = 0; i < firstarray.Length; i++)
            {
                Console.WriteLine(firstarray[i]*secondarray[i]);
            }
        }
    }
}
