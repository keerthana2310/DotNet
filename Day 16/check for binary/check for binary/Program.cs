using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_for_binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Enter the number");
            ////int num=int.Parse(Console.ReadLine());
            ////bool a = true;
            ////foreach(int i in )
            ////{
            ////    if (i==0 ||  i==1 )

            ////    {
            ////        a = true;
            ////        Console.WriteLine("Binary number is present"); }

            ////    else {
            ////        Console.WriteLine("Binary number is not present");

            ////        }
            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            Boolean a = true;
            while (num != 0)
            {
                if (num % 10 > 1)
                {

                    a = false;

                    num /= 10;
                    Console.WriteLine("binary is not present" + num);
                }

                else
                {
                    a = true;
                    Console.WriteLine("binary is present" + num);
                }
            }


        }
    }
}
