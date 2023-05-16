using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1234;
            int sum = 0;
            while(num > 0)
            {
                sum = sum + num % 10;
                num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
