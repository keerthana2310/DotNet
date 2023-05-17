using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_of_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 4, 5, 6 };
            int[] b = { 2,3, 4, 5,6 };
            bool c=Array.Equals(a,b);
            if(c==true)
            {
                Console.WriteLine("Arrays are equal");
            }
            else
            {
                Console.WriteLine("Arrays are not equal");
            }
        }
    }
}
