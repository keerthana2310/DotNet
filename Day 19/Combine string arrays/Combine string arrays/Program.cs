using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combine_string_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "cat", "dog", "fox" };
            string[] birds = { "hello", "janisha", "keerthana" };
            string[] a=animals.Union(birds).ToArray();
            foreach(var i in a)
            Console.Write(i);
        }
    }
}
