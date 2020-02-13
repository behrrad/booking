using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{

    [Route("hello")]
    [ApiController]
    public class ValuesController : ControllerBase 
    {
        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Hello World!";
        }
        
        class ResponseExample{
            public string response{ get; set; }
            public ResponseExample(string response){
                this.response = response;
            }
        }
        public IActionResult sayHello(){
            ResponseExample response = new ResponseExample("Hello world");
            return Ok(response);
        }
    }
}
