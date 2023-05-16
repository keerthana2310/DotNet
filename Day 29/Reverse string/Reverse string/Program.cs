using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            //Console.WriteLine("ABCD");
           string a = "ABCD";
           a = Console.ReadLine();
            // a = "ABCD";
            //Console.WriteLine("a{0}",a);
            string rev = "";

           int length=a.Length;
            for(int i=length-1;i>=0;i--)
            {
                rev = rev + a[i];
            }
            Console.WriteLine(rev);
        }
    }
}
