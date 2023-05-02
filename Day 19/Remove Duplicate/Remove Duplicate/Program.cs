using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 2, 7, 3, 2, 9, 2 };
            int[] dupl=num.Distinct().ToArray();
            foreach(var i in dupl)
            {
                Console.WriteLine(i);
            }
        }
    }
}
