using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static List.Customer;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer>li= new List<Customer>();
            Customer c1 = new Customer { id = 123, name = "scott", email = "fghj@hu.com",mark=30 };
            Customer c2 = new Customer { id = 101, name = "paru", email = "yhfk.com",mark=50 };
            Customer c3 = new Customer { id = 678, name = "kannan", email = "fvygbxw.com",mark=10 };
            li.Add(c1);
            li.Add(c2);
            li.Add(c3);
            Comparercustomers obj =new Comparercustomers();

            li.Sort(obj);
           // li.Sort();
            //li.Reverse();
            //li.Remove(c1 );
            foreach (var item in li)
            {
                Console.WriteLine(item.id+"  "+item.name+"  "+item.email+" "+item.mark);
            }

        }
    }
}
