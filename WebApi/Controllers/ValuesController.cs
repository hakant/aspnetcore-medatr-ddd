using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainA.Scenarios.HelloWorld;
using Microsoft.AspNetCore.Mvc;
using static DomainA.Scenarios.HelloWorld.GetHelloWorld;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public ValuesController() {
            
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(string name)
        {
            var request = new GetHelloWorld.Request {
                Name = name
            };

            return "";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
