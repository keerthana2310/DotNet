using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Colourcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string p = Console.ReadLine();
            string formatedPhoneNumber = string.Format("({0}) {1}-{2}", p.Substring(0, 3), p.Substring(3, 3), p.Substring(6, 4));
            
            if (p)
                {
                
              
                Console.WriteLine("valid");
                
            }
            
            else {
                Console.WriteLine("Invalid");
            }

            }
        }
    }

