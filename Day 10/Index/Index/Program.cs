using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Index a;
            a = new Index();
            a[3] = 43.2f;
            Console.WriteLine(a[3]);
        }
       
    }
}
