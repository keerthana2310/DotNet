using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using productsAPI.Dataconnection;
using productsAPI.Models;

namespace productsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductssController : ControllerBase
    {
        

        private readonly ProductDBContext _db;

        public ProductssController(ProductDBContext db)
        {
            _db = db;
        }

        [HttpPost]
        public ActionResult<ProductList> Create([FromBody]ProductList productList)
        {
            _db.Product.Add(productList);
            _db.SaveChanges();
            return Ok(productList);
        }

        [HttpGet]

        public ActionResult<ProductList> GetAll()
        {
            return Ok(_db.Product.ToList());
        }

        [HttpGet("{id:int}")]

        public ActionResult<ProductList> Get(int id)
        {
            var result = _db.Product.Find(id);
            return Ok(result);  
        }

        [HttpPut("{id:int}")]

        public ActionResult<ProductList> Put([FromBody]ProductList pro)
        {
            _db.Product.Update(pro);
            _db.SaveChanges();
            return Ok(pro);
        }

        [HttpDelete("{id:int}")]

        public ActionResult<ProductList> Delect(int id)
        {
            var result = _db.Product.Find(id);
            _db.Product.Remove(result);
            _db.SaveChanges();  
            return Ok();
        }

    }
}
