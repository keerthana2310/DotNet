using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1, s2;
            Console.WriteLine("Enter the first string");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            s2 = Console.ReadLine();
            char[] a = s1.ToCharArray();
            char[] b = s2.ToCharArray();
            Array.Sort(a);
            Array.Sort(b);

            a.SequenceEqual(b);
            Console.WriteLine("anagrams are equal");
            //string result1 = new string(a);
            //string result2 = new string(b);
            //if (result1 == result2)
            //{
            //    Console.WriteLine("strings are anagrams");

            //}
            //else
            //{
            //    Console.WriteLine("strings are not anagrams");
            //}


        }
    }
}
