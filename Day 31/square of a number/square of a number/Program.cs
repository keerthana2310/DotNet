//Write a program in C# Sharp to find the number of an array and the square of each number.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = {3,4,5,6,7};
            var query = from i in num
                        select new { square = i * i };
                      
            foreach(var item in query)
            {
                Console.WriteLine(item.square);
            }
        }
    }
}
