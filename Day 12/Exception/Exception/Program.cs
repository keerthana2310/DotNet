using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 10; int i = 0;
            try
            {
                k = k / i;
                
            }
            catch
            {
                Console.WriteLine("hello world");
            }

        }
    }
}
