using Employee.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Employee.Data
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {
           
        }
       public DbSet<EmployeeList> Employees {  get; set; }
    }
}
