using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using MagazinesDemo.Models;

namespace MagazinesDemo.Controllers
{
    public class MagazinesController : ApiController
    {
        public async Task<IEnumerable<Magazine>> GetMagazines()
        {
            return await MagazineSource.GetMagazinesAsync();
        }

        public IHttpActionResult GetMagazine(string id)
        {
            var m = MagazineSource.Magazines.SingleOrDefault(x => x.Id == id);
            if (m == null)
                return NotFound();
            return Ok(m);
        }
    }

}
