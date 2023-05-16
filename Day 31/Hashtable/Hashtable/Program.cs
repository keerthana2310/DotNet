using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Eid", 101);
            ht.Add("Ename", "Scott");
            ht.Add("Job", "HR");
            Console.WriteLine(ht["Ename"]);

            foreach(object key in ht.Keys)
            {
               // Console.WriteLine(key);
                Console.WriteLine(key+":"+ht[key]);
            }
        }
    }
}
