using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mail1 details");
            string[] mail1 = Console.ReadLine().Split(',');
            Mail m1 = new Mail(long.Parse(mail1[0]), mail1[1], mail1[2], mail1[3], mail1[4], Convert.ToDateTime(mail1[5]), Convert.ToDouble(mail1[6]));

            Console.WriteLine("Enter Mail2 details");
            string[] mail2 = Console.ReadLine().Split(',');
            Mail m2 = new Mail(int.Parse(mail2[0]), mail2[1], mail2[2], mail2[3], mail2[4], Convert.ToDateTime(mail2[5]), Convert.ToDouble(mail2[6]));
        }

    }   
}
