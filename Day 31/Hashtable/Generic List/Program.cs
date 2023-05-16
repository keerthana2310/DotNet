using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_List
{
    internal class Program
    {
        public class Generics
        {
            public bool compare(int a, int b)
            {
                if (a == b)
                    return true;
                else return false;
            }
        }
        static void Main(string[] args)
        {
            
            Generics g= new Generics();
            bool result=g.compare(1, 2);
            Console.WriteLine(result);
        }
    }
}
