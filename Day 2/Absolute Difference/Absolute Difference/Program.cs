//program for absolute difference
using System;
using System.Runtime.Remoting.Messaging;

namespace Absolute_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n , a = 51,Difference;
            Console.WriteLine("Enter the number");
            n = double.Parse(Console.ReadLine());
            Difference = absolute(n, a);
            Console.WriteLine("Absolute difference is {0} :",Difference);
        }
        static double absolute(double n, double a)
        {
           if(n>a)
            {
            double result = (n - a) * 3;
            return result;
           }
            else
         {
          double answer = a - n ;
            return answer;
          }
       }
  }
    
}
