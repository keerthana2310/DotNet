//The numbers which produce the remainder 0 after divided by 2 are :
//0 2 4 6 8
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3,2,4,6,8};

            var  query= from i in num
                        where(i%2==0)
                        select i;
            foreach(var n in query)
            {
                Console.WriteLine(n);
            }
        }
    }
}
