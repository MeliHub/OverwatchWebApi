using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class INCIDENTHISTORYController : ApiController
    {
        public IEnumerable<INCIDENTHISTORY> Get()
        {
            using (ReidiusDBEntities12 enteties = new ReidiusDBEntities12())
            {
                return enteties.INCIDENTHISTORY.ToList();
            }
        }
        public INCIDENTHISTORY Get(int id)
        {
            using (ReidiusDBEntities12 enteties = new ReidiusDBEntities12())
            {
                return enteties.INCIDENTHISTORY.FirstOrDefault(e => e.incidentHistoryID == id);
            }
        }
        public void Post([FromBody]INCIDENTHISTORY incidenthistory)
        {
            try
            {
                using (ReidiusDBEntities12 entities = new ReidiusDBEntities12())
                {
                    entities.INCIDENTHISTORY.Add(incidenthistory);
                    entities.SaveChanges();
                }

            }


            catch (Exception ex)
            {

            }

        }
    }
}
