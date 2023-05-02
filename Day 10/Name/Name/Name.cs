using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Name
{
    internal class Name
    {

        private string _fname;
        public string Fname
        {
            get
            { return _fname; }
            set { _fname = value; }
        }

        private string _sname;
        public string Sname
        {
            get
            { return _sname; }
            set { _sname = value; }
        }
        public Name()
        {

        }
        public Name(string fname, string sname)
        {
            _fname = fname;
            _sname = sname;
        }
        public void Fullname()
        {
             

            Console.WriteLine("full name is "+_fname +_sname);
            
        }
    
        
    
    }
}

