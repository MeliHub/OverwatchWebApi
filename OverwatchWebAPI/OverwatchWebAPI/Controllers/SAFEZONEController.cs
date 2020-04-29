using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class SAFEZONEController : ApiController
    {
        public IEnumerable<SAFEZONE> GetSafezones()
        {
            using (ReidiusDBEntities7 entities = new ReidiusDBEntities7())
            {
                return entities.SAFEZONE.ToList();
            }
        }
        public SAFEZONE GetSafezone(int id)
        {
            using (ReidiusDBEntities7 enteties = new ReidiusDBEntities7())
            {
                return enteties.SAFEZONE.FirstOrDefault(e => e.safezoneID == id);
            }
        }
        public void Post([FromBody]SAFEZONE safezone)
        {
            using (ReidiusDBEntities7 entities = new ReidiusDBEntities7())
            {
                entities.SAFEZONE.Add(safezone);
                entities.SaveChanges();
            }
        }
    }
}
