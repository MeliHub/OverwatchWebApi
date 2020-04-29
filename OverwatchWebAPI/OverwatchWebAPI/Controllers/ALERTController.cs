using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class ALERTController : ApiController
    {
        public IEnumerable<ALERT> GetAlerts()
        {
            using (ReidiusDBEntities5 entities = new ReidiusDBEntities5())
            {
                return entities.ALERT.ToList();
            }
        }
        public ALERT GetAlert(int id)
        {
            using (ReidiusDBEntities5 enteties = new ReidiusDBEntities5())
            {
                return enteties.ALERT.FirstOrDefault(e => e.alertID == id);
            }
        }
        public void Post([FromBody]ALERT alert)
        {
            using (ReidiusDBEntities5 entities = new ReidiusDBEntities5())
            {
                entities.ALERT.Add(alert);
                entities.SaveChanges();
            }
        }
    }
}
