using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPITest2.Controllers
{
    [Route("api")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Blah Blah Blah" };
        }
        [HttpGet("{id}")]
        public ActionResult<string> Get(string id)
        {
            if (id == "hello")
                return "hi";
            else if (id == "hi")
                return "hello";
            else
                return id;
        }
    }
}