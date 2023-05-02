using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amstrong_No
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int rev, revnum = 0;
            //int temp;
            //Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number of digits");
            //int digit = int.Parse(Console.ReadLine());
            //while (num > 0)
            //{
            //    rev = num % 10;
            //    revnum = revnum * 10 + rev;
            //    num = num / 10;
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int rem;
            int cube;
            int result = 0;
            int temp = num;
            while (num != 0)
            {
                rem = num % 10;                  //153%10=3 ,3*3*3=27 ,0+27=27  ,153/10=15
                cube = rem * rem * rem;
                result = result + cube;              //15%10=5 ,5*5*5=125 ,125+27=152, 15/10=1
                num = num / 10;                      // 1%10=1 ,1*1*1=1 ,1+152=153 ,1/10=0
            }
            num = temp;
            if(num==result)
            {
                Console.WriteLine("Amstrong number");
            }
            else
            {
                Console.WriteLine("Not an Amstrong");
            }

        }
        }
    }
