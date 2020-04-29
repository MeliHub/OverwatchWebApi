using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;
using System.Threading;

namespace OverwatchWebAPI.Controllers
{

    public class LOGINController : ApiController
    {
        public IEnumerable<LOGIN> Get()
        {
            using (ReidiusDBEntities10 enteties = new ReidiusDBEntities10())
            {
                return enteties.LOGINs.ToList();
            }
        }
        public HttpResponseMessage Get(int loginID, string password)
        {
            using (ReidiusDBEntities10 enteties = new ReidiusDBEntities10())
            {
                if (Login(loginID, password))
                {
                    return Request.CreateResponse(HttpStatusCode.OK, enteties.LOGINs.FirstOrDefault(e => e.loginID == loginID));
                }
                else
                {
                   return Request.CreateResponse(HttpStatusCode.BadRequest, "INCORRECT DETAILS");
                } 
            }
        }

        public static bool Login(int username, string password)
        {
            using (ReidiusDBEntities10 entities = new ReidiusDBEntities10())
            {
                return entities.LOGINs.Any(LOGIN => LOGIN.loginID.Equals(username) && LOGIN.password == password);
            }
        }

        public void Post([FromBody]LOGIN login)
        {
            try
            {
                using (ReidiusDBEntities10 entities = new ReidiusDBEntities10())
                {

                    entities.LOGINs.Add(login);
                    entities.SaveChanges();

                }

            }

            catch (Exception ex)
            {

            }
        }
    }
}
