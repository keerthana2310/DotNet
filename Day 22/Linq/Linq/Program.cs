using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] flowers = { "dahlia", "rose", "lilly", "lotus" };
            var fQuery =
                from flower in flowers
            //    where flower.StartsWith("l")
            //    select flower;
            //foreach(string f in fQuery)
            //{
            //    Console.WriteLine(f);
            //}
            let len=flower.Length
            where  len>3&& len<5
            select flower;
            foreach (string f in fQuery)
            {
                Console.WriteLine(f);
            }

        }
    }
}
