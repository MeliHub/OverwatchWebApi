using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class HOTSPOTController : ApiController
    {
        public IEnumerable<HOTSPOT> GetHotspots()
        {
            using (ReidiusDBEntities6 entities = new ReidiusDBEntities6())
            {
                return entities.HOTSPOT.ToList();
            }
        }
        public HOTSPOT GetHotspot(int id)
        {
            using (ReidiusDBEntities6 enteties = new ReidiusDBEntities6())
            {
                return enteties.HOTSPOT.FirstOrDefault(e => e.hotspotID == id);
            }
        }
        public void Post([FromBody]HOTSPOT hotspot)
        {
            using (ReidiusDBEntities6 entities = new ReidiusDBEntities6())
            {
                entities.HOTSPOT.Add(hotspot);
                entities.SaveChanges();
            }
        }
    }
}
