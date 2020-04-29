using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class SUBURBController : ApiController
    {
        public IEnumerable<SUBURB> GetSuburb()
        {
            using (ReidiusDBEntities8 entities = new ReidiusDBEntities8())
            {
                return entities.SUBURB.ToList();
            }
        }
        public SUBURB GetSuburb(int id)
        {
            using (ReidiusDBEntities8 enteties = new ReidiusDBEntities8())
            {
                return enteties.SUBURB.FirstOrDefault(e => e.suburbID == id);
            }
        }
        public void Post([FromBody]SUBURB suburb)
        {
            using (ReidiusDBEntities8 entities = new ReidiusDBEntities8())
            {
                entities.SUBURB.Add(suburb);
                entities.SaveChanges();
            }
        }
    }
}
