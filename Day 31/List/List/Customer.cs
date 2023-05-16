using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    //internal class Customer
    //{
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public string email { get; set; }
    //    public int mark { get; set; }
    //}
    internal class Customer : IComparable<Customer>
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public int mark { get; set; }

        public int CompareTo(Customer other)
        {
            if (this.id > other.id)
                return 1;
            else if (this.id < other.id)
                return -1;
            else return 0;
        }


        internal class Comparercustomers : IComparer<Customer>
        {
            //public int id { get; set; }
            //public string name { get; set; }
            //public string email { get; set; }
            //public int mark { get; set; }

            //public int Compare(Customer x, Customer y)
            //{
            //    if (x.name == y.name)
            //        return 1;
            //    else { return -1; }
            //}
            public int Compare(Customer x, Customer y)
            {
                if (x.mark > y.mark)
                    return 1;
                else if (x.mark < y.mark)
                    return -1;
                else return 0;
            }
        }
    }
}

