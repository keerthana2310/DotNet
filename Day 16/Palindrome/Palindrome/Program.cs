using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rem, temp ,revnum= 0; 
            Console.WriteLine("Enter the  number");
            int num=int.Parse(Console.ReadLine());
            temp = num;
            while(num>0)
            {
                rem = num % 10;
                revnum = revnum * 10 + rem;
                num = num / 10;

               

            }
            if (temp == revnum)
            {
               Console.WriteLine(revnum);
                Console.WriteLine("is palindrome");
            }
            else { Console.WriteLine("is not palindrome");
            }
        }
    }
}
