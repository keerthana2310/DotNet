using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prime_No
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 50;
            int count = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("prime no");

            }
            else
            {
                Console.WriteLine("Not a prime no");
            }



        }
    }
}

