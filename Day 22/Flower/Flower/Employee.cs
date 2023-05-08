using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Employee
{
    internal class Employee
    {
        private string _name;
        private string _city;
        public string Name {
            get {
                
               return _name; } 
            set { 
                _name = value; 
            }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public Employee()
        {

        }
        public Employee(string name,string city)
        {
            _name = name;
            _city = city;
        }

        public override string ToString()
        {
            return String.Format($"Name {_name} City{_city}");
        }

    }
}
