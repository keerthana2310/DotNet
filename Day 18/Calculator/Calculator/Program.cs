using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("Enter the  number1");
            int num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            int num2=int.Parse(Console.ReadLine());

            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine("Enter the option:");

            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    result=num1+ num2;
                    Console.WriteLine("The value is"+ result);
                    break;
                case 2:
                    result = num1 -num2;
                    Console.WriteLine("The value is"+ result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("The value is"+result);
                    break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine("The value is"+ result);
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;






            }
        }
    }
}
