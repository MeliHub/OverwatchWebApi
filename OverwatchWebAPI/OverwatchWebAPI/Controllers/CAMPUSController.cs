using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class CAMPUSController : ApiController
    {
        public IEnumerable<CAMPUS> Get()
        {
            using (ReidiusDBEntities11 enteties = new ReidiusDBEntities11())
            {
                return enteties.CAMPUS.ToList();
            }
        }
        public CAMPUS Get(int id)
        {
            using (ReidiusDBEntities11 enteties = new ReidiusDBEntities11())
            {
                return enteties.CAMPUS.FirstOrDefault(e => e.campusID == id);
            }
        }
        public void Post([FromBody]CAMPUS campus)
        {
            try
            {
                using (ReidiusDBEntities11 entities = new ReidiusDBEntities11())
                {
                    entities.CAMPUS.Add(campus);
                    entities.SaveChanges();
                }

            }


            catch (Exception ex)
            {

            }

        }
    }
}
