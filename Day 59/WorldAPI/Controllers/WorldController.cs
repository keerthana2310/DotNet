using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WorldAPI.Data;
using WorldAPI.Models;

namespace WorldAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorldController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        public WorldController(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public ActionResult<Countryy> Create([FromBody]Countryy countryy)
        {
            _db.World.Add(countryy);
            _db.SaveChanges();
            return Ok();
        }
        [HttpGet]
        
        public ActionResult<IEnumerable<Countryy>> GetAll()
        {
            return _db.World.ToList();
        }
        [HttpGet("{id:int}")]
        public ActionResult<Countryy> GetById(int id)
        {
           return _db.World.Find(id);
        }
        [HttpPut]
        public ActionResult<Countryy> Update([FromBody] Countryy countryy)
        {
            _db.World.Update(countryy);
            _db.SaveChanges();
            return Ok();
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeleteById(int id)
        {
            var world=_db.World.Find(id);
            _db.World.Remove(world);
            _db.SaveChanges();
            return Ok();
        }
    }
}
