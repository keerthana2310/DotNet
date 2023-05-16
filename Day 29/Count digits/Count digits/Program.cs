using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Count_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = 123456;
            int Count = 0;
            while(numbers>0)
            {
                numbers = numbers /10;
                Count++;

            }
            Console.WriteLine(Count);
        }
    }
}
