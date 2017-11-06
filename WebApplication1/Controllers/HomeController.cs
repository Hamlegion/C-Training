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
            return new string[] { "value1", "value2" };
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

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
