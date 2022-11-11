using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentsController : ControllerBase
    {
        // GET: api/<AgentsController>
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
                    AgentsListViewModel vm = new AgentsListViewModel();
                    vm.Status = 0;
                    vm.Agent = Agents.GetAll();
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


                /*ErrorResponse er = new ErrorResponse();
                er.Status = 500;
                er.ErrorMessage = "Missing or empty security headers";
                return Ok(er);*/
            }
        }

        // GET api/<AgentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AgentsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AgentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AgentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
