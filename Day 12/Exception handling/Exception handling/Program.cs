using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //when the 1st one is error then it will not go to nxt.It prints the 1st one.
            // int b = 2;
            int b = 7;
            int[] a = new int[5];
            try
            {
                int i = 10 / b;
                // a[10] = 9;
                // a[3] = 9;
                a[15] = 7;
            }
            catch(DivideByZeroException e) { 
                Console.WriteLine("Divide by zero error");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Index out of range");
            }
            finally
            {
                Console.WriteLine("finally");

            }
            Console.WriteLine("Remaining program");
        }
    }
}
