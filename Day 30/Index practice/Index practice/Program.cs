using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_practice
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Enter the string");
            string a=Console.ReadLine();
            Console.WriteLine("Enter the number");
            int b = int.Parse(Console.ReadLine());

            string newstr = a.Remove(b, 2);   //in paru get p and u
            Console.WriteLine(newstr);
        }
    }
}
