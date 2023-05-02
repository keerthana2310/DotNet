using Mail_practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mail_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Mail1 details:");
            //string[] s = Console.ReadLine().Split(',');
            //Mail m1=new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], DateTime.ParseExact(s[5], "dd-mm-yyyy", null),double.Parse(s[6]));

            //Console.WriteLine("Enter Mail2 details:");
            //string[] t = Console.ReadLine().Split(',');
            //Mail m2 = new Mail(long.Parse(t[0]), t[1], t[2], t[3], t[4], DateTime.ParseExact(t[5], "dd-mm-yyyy", null), double.Parse(t[6]));
            //Console.WriteLine("Enter Mail 1 details"+ m1);

            //Console.WriteLine("Enter Mail 2 details"+m2);
            //List<Mail> li = new List<Mail>();
            //for (int i = 1; i <= 2; i++)
            //{
            //    Console.WriteLine("Enter Mail{0} details", i);
            //    string[] s = Console.ReadLine().Split(',');
            //    Mail m1 = new Mail(long.Parse(s[0]), s[1], s[2], s[3], s[4], DateTime.ParseExact(s[5], "dd-mm-yyyy", null), double.Parse(s[6]));
            //    li.Add(m1);


            //}
            //int j = 1;
            //foreach(var mail in li)
            //{
            //    Console.WriteLine("mail{0}", j);
            //    Console.WriteLine(mail.ToString());
            //    j++;
            //}
            //if (li[0].Equals(li[1]))
            //    Console.WriteLine("mails are equal");
            //else Console.WriteLine("mails are different");

            List<Mail> ls = new List<Mail>();
            Console.WriteLine("Enter the name of folder");
            string name=Console.ReadLine();
            Mailfolder mf= new Mailfolder(name,ls);
            while(true)
            {
                Console.WriteLine("1.Add Mail\n 2.Delete Mail\n 3.Display Mails\n 4.Exit");
                Console.WriteLine("Enter your choice");
                int ch=int.Parse(Console.ReadLine());
                Console.WriteLine(mf.ToString());
                
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Enter the details of mail in CSV format");
                        string[]s=Console.ReadLine().Split(',');
                        Mail mail= new Mail(long.Parse(s[0]),s[1],s[2],s[3],s[4],DateTime.ParseExact(s[5],"dd-mm-yyyy",null),double.Parse(s[6]));
                        mf.AddMailToFolder(mail);
                        break;
                    case 2:
                        Console.WriteLine("Enter the id of mail to be deleted");
                        long id=long.Parse(Console.ReadLine());
                        mf.RemoveMailFromFolder(id);
                        break;
                        case 3:
                        mf.DisplayMails();
                            break;
                    case 4:
                        break;
                        case 5:
                        Console.WriteLine("invalid choice");
                        break;
                        

                }

            }
            


            
               
            
        }

    }
}
