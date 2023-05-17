using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_no.in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,2,4,5,6};
            int n = arr.Length + 1;
            int totalsum =( n*(n + 1)) / 2;

           int  arrsum = 0;
            
            foreach(int num in arr)
            {
                arrsum += num;
            }
            int missingno = totalsum - arrsum;
            Console.WriteLine(missingno);


          
        }
    }
}
