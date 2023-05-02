using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList s = new SortedList();
            
            s.Add("Maharashtra ","Mumbai");
            s.Add("Karnataka ", "Banglore");
            s.Add("Andrapradesh", "Hyderabad");
            s.Add("Tamilnadu","Chennai");
            s.Add("Bihar", "Patna");
             
                foreach(var item in s.Keys)
            {
                Console.WriteLine(item);          //1st elements get printed , key is integer
            }
                foreach(var item in s.Values)
            {
                Console.WriteLine(item);           //2nd element get printed ,value is string
            }

        }
    }
}
