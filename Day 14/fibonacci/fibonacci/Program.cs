using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
           int p1 = 0, p2 = 1, p3;
            Console.WriteLine("Enter the input");
            int number=int.Parse(Console.ReadLine());
            Console.WriteLine(p1 +""+ p2);
           for(int i=2;i<number;i++)
            {
                p3 = p1 + p2;
                Console.WriteLine(""+p3);
                p1 = p2;
                p2 = p3;
            }
        }
    }
}
