using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string[] a=Console.ReadLine().Split(',');
            //string  firstChar = a[0];
            //  string secondchar = a[1];
           // ()
          for (int i= 0; i < a.Length; i++)
            {
                if (a[i].StartsWith("j")||a[i].Substring(2) == "k")
                {
                   // a[i].Remove(2);
                    Console.WriteLine(a[i]);
                }
                //else
                //{
                //    string rrr = (a[i].Substring(1));
                //    Console.Write(rrr);
                //  //  Console.WriteLine(firstChar);
                //}
                
            }
            //if (secondchar == 'b')
            //{
            //    secondchar = string[1];
            //}
            //else
            //{
            //    firstchar = '/0';
            //}

        }
    }
}
