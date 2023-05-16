using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,object>dt=new Dictionary<string,object>();
            dt.Add("Email", "fghjk@hjk.com");
            dt.Add("Id", 123);
            //foreach(var key in dt.Keys)
            //{
            //    Console.WriteLine(key);
            //}
            foreach(var value in dt.Values)
            {
                Console.WriteLine(value);
            }

        }
    }
}
