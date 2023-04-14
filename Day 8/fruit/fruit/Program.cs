using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace fruit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            orange o1 = new orange(342, "Nagpur Orange", "Telungana");
            o1.display();
        }
    }
    public class fruit
    {
         private int _fruitId;
        public int FruitId
        {

            get { return _fruitId; }
            set
            {
                if (_fruitId != 0) _fruitId = value;
                else Console.WriteLine("Invalid");
            }
        }
    

         private string _fruitName;
         public string FruitName
         {
            get { return _fruitName; }
            set
            {
                if (_fruitName != null) _fruitName = value;
                else Console.WriteLine("Invalid");
            }
         }
            public fruit()
            {

            }
        public fruit(int fruitId,string fruitName)
        {
            _fruitId = fruitId;
            _fruitName = fruitName;
        }
        public void print()
        {
            Console.WriteLine("fruit no:" + _fruitId);
            Console.WriteLine("fruit name:" + _fruitName);
        }


    }

    public class orange : fruit
    {
        private string _origin;

        public string[] locations = { "Mumbai", "Maharashtra", "Telungana" };

        public string Origin
        {


            get { return _origin; }
            set
            {
                if (Array.BinarySearch(locations, value) >= 0) _origin = value;
                else Console.WriteLine("Invalid");
            }
        }
            public orange()
            {
            
            }
        public orange(int fruitId, string fruitName,string origin):base(fruitId,fruitName)
        {
            _origin = origin;
            
        }
        public void display()        //public new void print()
        {
            base.print();
            Console.WriteLine("origin of fruit: " + _origin);
                
                
                
        }

    }
}

    
            
        

    

        