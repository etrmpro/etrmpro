using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CurveManagement.Controllers
{
    public class CurveValueController : ApiController
    {
        // GET: api/CurveValue
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CurveValue/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CurveValue
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CurveValue/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CurveValue/5
        public void Delete(int id)
        {
        }
    }
}
