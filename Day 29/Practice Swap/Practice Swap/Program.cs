using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int b=int.Parse(Console.ReadLine());
            //int temp = a;
            //a = b;
            //b = temp;
            a = a + b;
            b = a - b;
            a= a-b;

            Console.WriteLine("After swapping{0} {1}:",a,b);

        }
    }
}
