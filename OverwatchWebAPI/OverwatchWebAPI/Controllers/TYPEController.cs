using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class TYPEController : ApiController
    {

        public IEnumerable<TYPE> GetTypeInfo()
        {
            using (ReidiusDBEntities9 entities = new ReidiusDBEntities9())
            {
                return entities.TYPE.ToList();
            }
        }
        public TYPE GetType(int id)
        {
            using (ReidiusDBEntities9 enteties = new ReidiusDBEntities9())
            {
                return enteties.TYPE.FirstOrDefault(e => e.typeID == id);
            }
        }
        public void Post([FromBody]TYPE type)
        {
            using (ReidiusDBEntities9 entities = new ReidiusDBEntities9())
            {
                entities.TYPE.Add(type);
                entities.SaveChanges();
            }
        }
    }
}
