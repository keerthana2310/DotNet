using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_add
{
    internal class Program
    {
        public delegate int sum(int x, int y);
        static void Main(string[] args)
        {
            int result;
            sum s = delegate (int n, int m)
            {
                return n + m;
            };
            result=s(10, 20);
            Console.WriteLine("sum of"+ result);



        }
    }
}
