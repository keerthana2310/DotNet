using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruirement_5
{
    public class InvalidEmailException:Exception
    {
        string _email;
        public InvalidEmailException()
        {

        }
        public InvalidEmailException(string email)
        {
            _email = email;
        }
        public void inform()
        {
            Console.WriteLine("Invalid mailid");
        }
    }
}
