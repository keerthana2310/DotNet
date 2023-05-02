using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Duplicates
{
    internal class Program
    {
        static void Main(string[] args)
       

        {
            
              string str;
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            string result = "";
            for(int i=0;i<str.Length; i++)
            {
                if (!result.Contains(str[i]))
                    result += str[i];
                
            }
            Console.WriteLine(result);

        }
    }
}
