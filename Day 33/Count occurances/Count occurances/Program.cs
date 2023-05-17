using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_occurances
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello world";
            int total = s.Length;
            int remove = s.Replace("l", "").Length;
            int count = total - remove;
            Console.WriteLine(count);

        }
    }
}
