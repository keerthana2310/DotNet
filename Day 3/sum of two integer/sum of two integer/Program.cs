//Sum of two integer
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace sum_of_two_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b,sum;
            Console.WriteLine("Enter the first number");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = int.Parse(Console.ReadLine());
            sum = addition(a, b);
            Console.WriteLine("Sum of two integer{0} and{1} is {2} ", a, b, sum);



        }
        static int addition(int a,int b)
        {
            int sum=0;
            if(a==b)
            {
                 sum = (a + b) * 3;
                
            }
            return sum;


        }
    }
}
