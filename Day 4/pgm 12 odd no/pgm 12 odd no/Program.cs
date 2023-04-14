//Write a C# program to print the odd numbers from 1 to 99. Prints one number per line
using System;


namespace pgm_12_odd_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("print odd no. from 1 to 99");
            int num = 99;
            for(int i=1;i<=num;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                }
            }
            
             Console.WriteLine("print a num");
            int num =int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
