//Write a program to read a non-negative integer n, compute the sum of its digits.
//If sum is greater than 9 repeat the process and calculate the sum once again until the final sum comes to single digit.Return the single digit.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            int rem = 0;int sum=0;int rem1 = 0;
            bool r = true;
            while(r)
            {
                rem = n % 10;
             
                sum = sum+ rem;
                n = n / 10;
                Console.WriteLine(sum+" 1st loop");
                Console.WriteLine(rem);
                Console.WriteLine(n);
                
                    while (sum > 9)
                    {
                        rem1 = sum % 10;
                        sum = sum / 10;
                        sum = sum + rem1;
                       Console.WriteLine(sum+"second loop");
                        
                    }
            if(sum <= 9 && n == 0)
                {
                    r = false;
                }
                  
               
            }
            Console.WriteLine(sum);
        }
    }
}
