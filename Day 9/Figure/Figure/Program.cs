using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure fig= new square();
            fig.Dimension = 10;
            Console.WriteLine(fig.Area());
            Console.WriteLine(fig.Perimeter());

        }
        abstract class Figure
        {
            public int Dimension;
            public abstract double Area();
            public abstract double Perimeter();
        }
        class square : Figure
        {
            public override double Area()
            {
                return Dimension * Dimension;
            }
            public override double Perimeter()
            {
                return 4* Dimension;
            }

        }
        class circle : Figure
        {
            public override double Area()
            {
                return Math.PI * Dimension * Dimension;
            }
            public override double Perimeter()
            {
                return 2 * Math.PI * Dimension;
            }
        }
    }
}
