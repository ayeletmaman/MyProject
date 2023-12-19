using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentController : ControllerBase
    {
        private static List<Apartment> _apartments = new List<Apartment>();
        private ActionResult<IEnumerable<string>> _apartment;
    
        // GET: api/<ApartmentController>
        [HttpGet]
        public ActionResult <IEnumerable<string>> Get()
        {
            return _apartment;
        }
  

        // GET api/<ApartmentController>/5
        [HttpGet("{id}")]
        public ActionResult<Apartment> Get(int id)
        {
            var apartment = _apartments.Find(a => a.Id == id);
            if (apartment == null)
            {
                return NotFound();
            }
            return apartment;
        }


        // POST api/<ApartmentController>
        [HttpPost]
        public ActionResult<Apartment> Post([FromBody] Apartment apartment)
        {
            if (apartment.Name.Length > 50)
            {
                return BadRequest(new { Message = "apartment name should be 50 length maximum" });
            }
            var newApartment = new Apartment { Id = 1, Name = apartment.Name };
            _apartments.Add(newApartment);
            return newApartment;
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Apartment apartment)
        {
            return StatusCode(418, new { Message = "what is this?" });
        }

        // PUT api/<ApartmentController>/5
        [HttpPut("{id}/status")]
        public ActionResult Put(int id, [FromBody] string status)
        {
            return null;
        }
        // DELETE api/<ApartmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            //TODO delete
            return Ok();
        }

    }
}
