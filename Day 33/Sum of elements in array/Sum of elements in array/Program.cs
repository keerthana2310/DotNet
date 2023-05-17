using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_elements_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = {3,5,7,9,10};
            int sum = 0;
            for(int i=0; i<a.Length; i++)
            {
                sum += a[i];
            }
            Console.WriteLine(sum);
        }
    }
}
