using Microsoft.EntityFrameworkCore;
using productsAPI.Models;

namespace productsAPI.Dataconnection
{
    public class ProductDBContext : DbContext
    {

        public ProductDBContext( DbContextOptions<ProductDBContext> option):base(option)
        {
            
        }

      public  DbSet<ProductList> Product {  get; set; }
    }
}
