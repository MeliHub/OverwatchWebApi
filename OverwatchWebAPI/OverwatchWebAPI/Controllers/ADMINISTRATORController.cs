using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class ADMINISTRATORController : ApiController
    {
        public IEnumerable<ADMINISTRATOR> GetAdministrators()
        {
            using (ReidiusDBEntities4 entities = new ReidiusDBEntities4())
            {
                return entities.ADMINISTRATOR.ToList();
            }
        }
        public ADMINISTRATOR GetAdmin(int id)
        {
            using (ReidiusDBEntities4 enteties = new ReidiusDBEntities4())
            {
                return enteties.ADMINISTRATOR.FirstOrDefault(e => e.adminID == id);
            }
        }
        public void Post([FromBody]ADMINISTRATOR admin)
        {
            using (ReidiusDBEntities4 entities = new ReidiusDBEntities4())
            {
                entities.ADMINISTRATOR.Add(admin);
                entities.SaveChanges();
            }
        }
    }
}
