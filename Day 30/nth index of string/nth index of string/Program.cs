using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nth_index_of_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first string");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the second string");
            string s2=Console.ReadLine();
            Console.WriteLine("Enter the index no.");
            int n=int.Parse(Console.ReadLine());
            s1.ToLower();
            s2.ToLower();
            if (s1[n] == s2[s2.Length -2])
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
    }
}
