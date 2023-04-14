//palindrome 
using System;


namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, revNum=0;
            Console.WriteLine("Enter a number");
            num=int.Parse(Console.ReadLine());
            while (num != 0) 
            {
                revNum = revNum * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine("the palindrome series is {0}", revNum);
            //for printing words
            string str, revString = " ";
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revString = revString + str[i];
            }
            Console.WriteLine("Reverse string is {0}", revString);
            
        }
    }
}
