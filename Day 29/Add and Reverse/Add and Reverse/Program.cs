using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 15, 20, 25, 30, 100 };
            int num = 15;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > num)
                {
                    sum += a[i];
                }


            }
            int revresult = 0;
            while (sum > 0)
            {

                revresult = revresult * 10 + sum % 10;
                sum = sum / 10;

            }
            Console.WriteLine(revresult);
        }
    }
}






