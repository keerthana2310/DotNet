using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string ");
            string s  = Console.ReadLine();
            //  Console.WriteLine();
                
            if (s[0] == 'j')
            {
                Console.WriteLine(s.Substring(1));                   //if 1st anf 2nd element is j and k will remove
                if (s[1] == 'k')
                {
                    Console.WriteLine(s.Remove(1, 1));
                }
            }
            else if (s[1] == 'k')
            {                                               //if 2nd element is k it will remove
                Console.WriteLine(s.Remove(1, 1));
               
            }
            else
            {
                Console.WriteLine(s.Substring(2));
            }                                                   //if  both j and k present.
        }
    }
}
