using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class PERSONController : ApiController
    {
        public IEnumerable<PERSON> GetPerson()
        {
            using (ReidiusDBEntities enteties = new ReidiusDBEntities())
            {
                return enteties.PERSON.ToList();
            }
        }
        public PERSON GetPerson(int id)
        {
            using (ReidiusDBEntities enteties = new ReidiusDBEntities())
            {
                return enteties.PERSON.FirstOrDefault(e => e.personID == id);
            }
        }
        public void Post([FromBody]PERSON person)
        {
            try
            {
                using (ReidiusDBEntities entities = new ReidiusDBEntities())
                {
                    entities.PERSON.Add(person);
                    entities.SaveChanges();
                }

            }


            catch (Exception ex)
            {
                 
            }

        }
    }
}
