using System;


namespace constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp();
            Emp e2 = new Emp(300, "Rahul", 30000);
            Console.WriteLine("Enter Employee Id:");
            e1.EmpId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");
            e1.Name = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary:");
            e1.Salary = Decimal.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");
            Console.WriteLine("EmpId :"+e2.EmpId);
            Console.WriteLine("Name:"+e2.Name);
            Console.WriteLine("salary:"+e2.Salary);
        }
    }
}
