using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class EMERGENCYSERVICEController : ApiController
    {
        public IEnumerable<EMERGENCYSERVICE> GetEmergencies()
        {
            using (ReidiusDBEntities2 entities = new ReidiusDBEntities2())
            {
                return entities.EMERGENCYSERVICE.ToList();
            }
        }
        public EMERGENCYSERVICE GetEmergencyService(int id)
        {
            using (ReidiusDBEntities2 enteties = new ReidiusDBEntities2())
            {
                return enteties.EMERGENCYSERVICE.FirstOrDefault(e => e.emergencyServiceID == id);
            }
        }
        public void Post([FromBody]EMERGENCYSERVICE emergency)
        {
            using (ReidiusDBEntities2 entities = new ReidiusDBEntities2())
            {
                entities.EMERGENCYSERVICE.Add(emergency);
                entities.SaveChanges();
            }
        }
    }
}
