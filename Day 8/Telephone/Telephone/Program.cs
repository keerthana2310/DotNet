//create a base class, Telephone, and derive a class ElectronicPhone from it. In Telephone, create a protected string member phonetype and a public method Ring( ) which outputs a text message such as this: “Ringing the <phonetype>.” In ElectronicPhone, the constructor should set the phonetype to “Digital.” In the Run( ) method, call Ring( ) on the ElectronicPhone to test the inheritance.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicPhone phone = new ElectronicPhone();
            phone.Ring();
        }
    }
        public class Telephone
        {
            protected string _phonetype;
            public string Phonetype
            {
                get
                {
                    return _phonetype;
                }
                set
                { if (_phonetype != null) _phonetype = value; }

            }
        

       



        public void Ring()

            {
                Console.WriteLine("Ringing the {0}", _phonetype);
            }
            public Telephone()
            {

            }
            public Telephone(string phone)
            {
                _phonetype = phone;

            }
        }
    
      
        public class ElectronicPhone:Telephone
        {
            
            public ElectronicPhone()
            {
                _phonetype = "Digital";

            }


        }
    }

