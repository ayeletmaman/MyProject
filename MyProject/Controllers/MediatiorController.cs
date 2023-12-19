using Microsoft.AspNetCore.Mvc;
using MyProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediatiorController : ControllerBase
    {
        private DataContext _datacontext;
        public MediatiorController(DataContext datacontext)
        {
            _datacontext = datacontext;
        }
        // GET: api/<MediatiorController>
        [HttpGet]
        public ActionResult <IEnumerable<Mediatior>> Get()
        {
            _datacontext = new DataContext();
            return _datacontext._mediatior;
        }

        // GET api/<MediatiorController>/5
        [HttpGet("{id}")]
        public ActionResult<Mediatior> Get(int id)
        {
        var mediatior = _mediatirs.Find(m=>m.Id == id); 
            if (mediatior == null)
            {
                return NotFound();
            }
            return mediatior;
        }

        // POST api/<MediatiorController>
        [HttpPost]
        public ActionResult<Mediatior> Post([FromBody] Mediatior mediatior )
        {
            if (mediatior.Name.Length > 50)
            {
               return BadRequest(new { Message = "mediatior name should be 50 length maximum" });
            }
           var newMediatior=new Mediatior { Id=1,Name=mediatior.Name};
           _mediatirs.Add(newMediatior);
            return newMediatior;
                }
        
        // PUT api/<MediatiorController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Mediatior mediatior)
        {
            return StatusCode(418, new { Message = "what is this?" });
        }
        // PUT api/<MediatiorController>/5
        [HttpPut("{id}/status")]
        public ActionResult Put(int id, [FromBody] string status)
        {
            return null;
        }

        // DELETE api/<MediatiorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //TODO delete
            return Ok();
        }
    }
}
