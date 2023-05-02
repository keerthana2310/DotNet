using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comma_seperated_from_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = { "bird", "cat", "fish" };
            string b=String.Join(" ", a);
            Console.WriteLine(b);
            
        }
    }
}
