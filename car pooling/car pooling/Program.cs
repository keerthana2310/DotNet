using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_pooling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Member 1:");
            //string[] mm1 = Console.ReadLine().Split(' ');
            //DateTime dt = Convert.ToDateTime(mm1[6]);
            //DateTime dt1 = Convert.ToDateTime(mm1[7]);
            //Member m1 = new Member(long.Parse(mm1[0]), mm1[1], mm1[3], mm1[4], mm1[5], dt, dt1);
            //Console.WriteLine(m1);
            //Console.WriteLine("Member 2:");
            //string[] mm2 = Console.ReadLine().Split(',');
            //DateTime dt2 = Convert.ToDateTime(mm2[6]);
            //DateTime dt3 = Convert.ToDateTime(mm2[7]);
            //Member m2 = new Member(long.Parse(mm2[0]), mm2[1], mm2[2], mm2[4], mm2[5], dt2, dt3);
            //Console.WriteLine(m2);
            //if (m1.Equals(m2))
            //{
            //    Console.WriteLine("Member 1 is same as Member 2");
            //}
            //else
            //{
            //    Console.WriteLine("Member 1 and Member 2 are different");
            //}


            List<Member> li = new List<Member>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Member {0}", i + 1);
                Console.WriteLine("Id:");
                long id = long.Parse(Console.ReadLine());
                Console.WriteLine("first name:");
                string firstname = Console.ReadLine();

                Console.WriteLine("last name:");
                string lastname = Console.ReadLine();

                Console.WriteLine("email:");
                string email = Console.ReadLine();

                Console.WriteLine("contact number:");
                string contactnumber = Console.ReadLine();

                Console.WriteLine("license number:");

                string licensenumber = Console.ReadLine();

                Console.WriteLine("License start date:");
                DateTime licensestartDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("License Expiry date:");
                DateTime licenseExpiryDate = DateTime.Parse(Console.ReadLine());
                Member m1 = new Member(id, firstname, lastname, email, contactnumber, licensenumber, licensestartDate, licenseExpiryDate);
                li.Add(m1);

            }
            foreach (Member item in li)
            {
                Console.WriteLine(item);
            }
            if (li[0].Equals(li[1]))
            {
                Console.WriteLine("Member 1 is same as Member2");
            }
            else
            {
                Console.WriteLine("Member 1 and 2 are different");
            }

        }
    }
}
