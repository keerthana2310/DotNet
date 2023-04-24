using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s1 = new shape();
            s1.Drawshape();
            Circle s2 = new Circle();
            s2.Drawshape();
            shape s3 = new Circle();
            s3.Drawshape();
            shape s4 = new Rectangle();
            s4.Drawshape();
        } } }








            //array of references of base class refering
            //derive class object
         /*   shape[] p =
            {
                new Circle(),
                new Rectangle(),
                new Circle(),
                new Rectangle(),
                new Circle(),
            };
            for(int i=0;i<p.Length;i++)
            {
                p[i] = Drawshape();
            }
            shape t = null;
            Console.WriteLine("Enter Shape:");
            string shape = Console.ReadLine();

            if (shape.ToLower() == "circle")
            {
                t = new Circle();
            }
            else (shape.ToLower() == "rectangle")

        }
    }
}
*/