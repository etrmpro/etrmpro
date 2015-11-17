using CurveManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CurveManagement.Controllers
{
    public class CurveController : ApiController
    {
        CurveManagementDbContext dbContext = new CurveManagementDbContext();

        // GET api/curve
        public IEnumerable<Curve> Get()
        {
            return dbContext.Curves.ToList();
        }

        // GET api/curve/5
        public Curve Get(int id)
        {
            return new Curve();
        }

        // POST api/curve
        public void Post([FromBody]Curve value)
        {
        }

        // PUT api/curve/5
        public void Put(int id, [FromBody]Curve value)
        {
        }

        // DELETE api/curve/5
        public void Delete(int id)
        {
        }
    }
}