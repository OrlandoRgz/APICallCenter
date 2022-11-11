using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StationController : ControllerBase
    {
        // GET: api/<StationController>
        [HttpGet]
        public ActionResult<string> Get()
        {
            //headers
            string username = Request.Headers["username"];
            string token = Request.Headers["token"];

            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(token))
            {
                if (Security.ValidateToken(username, token))
                {
                    StationListViewModel vm = new StationListViewModel();
                    vm.Status = 0;
                    vm.Station = Station.GetAll();
                    return Ok(vm);
                }
                else
                {
                    return Ok(Security.GetError(SecurityError.InvalidToken));
                }
            }
            else
            {
                return Ok(Security.GetError(SecurityError.MissingOrEmptySecurityHeaders));
            }
        }

        // GET api/<StationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
