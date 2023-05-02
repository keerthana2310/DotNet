using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonym
{
    internal class Program
    {
        public delegate void CountIt();
        static void Main(string[] args)
        {
            CountIt count = delegate
        {
            for (int i = 1; i < 10; i++)  //between {  };    is the method.
            
                Console.WriteLine(i);
            };
            count();

        }


    }
    }
