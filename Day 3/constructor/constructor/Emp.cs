// code for clss emp
using System;


namespace constructor
{
   public class Emp
    {
        public int EmpId;
        public string Name;
        public decimal Salary;
        public Emp()
        {
        }
        public Emp(int empId,string name,decimal salary)
        {
            EmpId = empId;
            Name = name;
            this.Salary = salary;
        }
    }
}
