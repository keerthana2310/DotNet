
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public Flower
            //List<Flower> FlowerList = new List<Flower>();
            //FlowerList.Add(new Flower("dahlia", 5));
            //FlowerList.Add(new Flower("lotus", 20));
            //FlowerList.Add(new Flower("lilly", 6));
            //FlowerList.Add(new Flower("daffodia", 7));

            //var fquery
            //    from Flower in FlowerList
            //    where Flower.name,flower.petals descending
            //    orderby flower.petals
            //    select 
            List<Employee> EmployeeList = new List<Employee>();


            EmployeeList.Add(new Employee("Ram","Mumbai"));
            EmployeeList.Add(new Employee("Santhosh","chennai"));
            EmployeeList.Add(new Employee("Mohan","kerala" ));
            EmployeeList.Add(new Employee("Abi", "kerala"));
            EmployeeList.Add(new Employee("Bindu","kanyakumari" ));
            var fquery = from Employee e in EmployeeList
                         orderby e.City
                         group e by e.City;
                       


            foreach(var f in fquery)
            {
                Console.WriteLine("Employees with  " + f.Key + " City");
                foreach (var e in f)
                { Console.WriteLine(" " +e.Name); }
            }


        }
    }
}
