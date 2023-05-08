using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "kar thik";
            int result = a.WordCount();
            Console.WriteLine(result);
        }
    }
}
