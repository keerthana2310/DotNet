using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string");
            str= Console.ReadLine();

            char[]arr= str.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == 'a' || arr[i] == 'e' || arr[i] == 'i' || arr[i] == 'o' || arr[i] == 'u')
                   
                    Console.WriteLine("contains vowel");
                else
                {
                    Console.WriteLine("not found");
                }
            }
        }
    }
}
