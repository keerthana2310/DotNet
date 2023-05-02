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
            List<Mail>li= new List<Mail>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter Mail{0} detail", i + 1);
                string[] s = Console.ReadLine().Split(',');
                Mail m = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], DateTime.ParseExact(s[5], "dd-MM-YY", null), double.Parse(s[6]));

                li.Add(m);

            }
            int j = 1;
            foreach (var item in li)
            {
                Console.WriteLine("mail{0}", j);
                Console.WriteLine(item.ToString());
                j++;
            }
            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("Mail 1 is same as Mail2");

            }
            else
            {
                Console.WriteLine("Mail 1 is not same as Mail2");
            }
        }

    }   
}
