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
            string str, revString = "";
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    revString = revString + str[i];
            //}
            //Console.WriteLine("Reverse string is:{0}", revString);

            char [] a=str.ToCharArray();
            
            for(int i=str.Length-1;i>=0; i--)
            {
                revString= revString + str[i];
            }
            Console.WriteLine("Enter the reversed array:{0}", revString);
        }
        
    }
}
