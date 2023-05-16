using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Day_in_a_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int year=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the month");
            int month=int.Parse(Console.ReadLine());
            int days = 0;
            if(month==0||month==2||month==4||month==6||month==7||month==9||month==11)
                {
            
                days = 31;
            }else if(month==3 || month == 5 || month == 8 || month == 10)
                {
                days = 30;
                  }
            else if(month==1)
            {
                GregorianCalendar c = new GregorianCalendar();
                bool b = c.IsLeapYear(year);
                    if(b==true)
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
            }
            Console.WriteLine(days);
        }
    }
}
