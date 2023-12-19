using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private static List<Buyer> buyers = new List<Buyer>();
        private ActionResult<IEnumerable<string>> _buyer;
        private object _buyers;

        // GET: api/<BuyerController>
        [HttpGet]
        public ActionResult< IEnumerable<string>> Get()
        {
            return _buyer;
        }

        // GET api/<BuyerController>/5
        [HttpGet("{id}")]
        public ActionResult<Buyer> Get(int id)
        {
            var buyer = _buyer.Find(b=>b.Id== id);
            if (buyer == null)
            {
                return NotFound();
            }
            return buyer;
        }
      
        // POST api/<BuyerController>
        [HttpPost]
        public ActionResult<Buyer> Post([FromBody] Buyer buyer)
        {
            if (buyer.Name.Length > 50)
            {
                return BadRequest(new { Message = "buyer name should be 50 length maximum" });
            }
            var newBuyer = new Buyer { Id = 1, Name = buyer.Name };
            _buyers.Add(newBuyer);
            return newBuyer;
        }

        // PUT api/<BuyerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Buyer buyer)
        {
            return StatusCode(418, new { Message = "what is this?" });
        }

        // PUT api/<BuyerController>/5
        [HttpPut("{id}/status")]
        public ActionResult Put(int id, [FromBody] string status)
        {
            return null;
        }
       
        // DELETE api/<BuyerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //TODO delete
            return Ok();
        }
   
    }
}
