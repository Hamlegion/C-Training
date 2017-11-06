using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/home")]
    public class HomeController : ApiController
    {
        // GET: api/Home
        [HttpGet]
        [Route("")]
        public IEnumerable<string> GetBasicInfo()
        {
            return new string[] { "Hello World, this is a master commit" };
        }

        // GET: api/Home/5
        [HttpGet]
        [Route("{accountId}")]
        public string Get(int accountId)
        {
            return "value";
        }

        // POST: api/Home
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
    }
}
