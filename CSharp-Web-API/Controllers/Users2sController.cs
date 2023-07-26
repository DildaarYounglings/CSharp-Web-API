using Microsoft.AspNetCore.Mvc;
using System.Collections;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CSharp_Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Users2sController : ControllerBase
    {
        // GET: api/<Users2sController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<Users2sController>/5
        [HttpGet("{id}")]
        public ArrayList Get(int id)
        {
            var stringArray = new string[] { "value1", "value2" }; ArrayList result = new ArrayList(){stringArray[id]};
            return result;
        }

        // POST api/<Users2sController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
 
            return Ok();
        }

        // PUT api/<Users2sController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Users2sController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
