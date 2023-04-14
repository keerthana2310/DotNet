//Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string
using System;
using System.Diagnostics.Eventing.Reader;

namespace Count_characters
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s;
            int alpha = 0;
            int digit = 0;
            int spec = 0;
            int i = 0;

            Console.WriteLine("Enter the input string");
            s = Console.ReadLine();


            while (i < s.Length)
            {
                if ((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z'))
                {
                    alpha++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {

                    digit++;
                    }
                else
                {
                    spec++;
                }
                i++;


            }
            Console.WriteLine("total no.of alphabets is {0},total no.of digit is {1}and total no.of special is {2}", alpha, digit, spec);
        }
    }
}