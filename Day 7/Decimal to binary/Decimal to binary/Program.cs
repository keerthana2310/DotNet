//Decimal to binary conversion
using System;
using System.Globalization;

namespace Decimal_to_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a decimal number");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
                int i = 0;
                while(num!=0)
                {
                arr[i]=num % 2;
                num = num / 2;
                i++;

                }
                for(int j=i-1;j>=0;j--)
                {
                Console.WriteLine(arr[j]);
                }
;            
        }
    }
}
