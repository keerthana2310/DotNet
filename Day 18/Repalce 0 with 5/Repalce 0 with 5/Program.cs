using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Repalce_0_with_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{
            //    Console.WriteLine("Enter the number:");
            //    int n=int.Parse(Console.ReadLine());
            //    int sum = 0;
            //    int rem, rev = 0;
            //    while(n>0)
            //    {
            //       int num = n % 10;
            //        if(num == 0)
            //        {
            //            num = 5;
            //        }
            //        sum = sum * 10 + num;
            //        n = n / 10;

            //    }
            //     while(sum>0)
            //    {
            //        rem = sum % 10;
            //        rev = rev * 10 + rem;
            //        sum = sum / 10;
            //    }
            //    Console.WriteLine(rev);
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            string a=n.ToString();
            string b = a.Replace('0', '5');
            Console.WriteLine(b);

        }
    }
}
