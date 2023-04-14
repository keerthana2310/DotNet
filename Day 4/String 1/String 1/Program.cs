//write a program in c# to compare two string without using string library function
using System;
using System.Threading;

namespace String_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string");
            string a=Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string b=Console.ReadLine();

            int x = a.Length;
            int y= b.Length;
            int r= 0;
            if(x==y)
            {
                for( int i=0; i<x; i++)
                {
                    if (a[i]== b[i])
                    {
                        r++;
                    }
                    else
                    {
                        r= 0;
                    }
                }

            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
            if (r==0)
            {
                Console.WriteLine("Length are same but characters are different");
            }
            else
            {
                Console.WriteLine("Length and characters are same");
            }
        }
    }
}
