using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;
namespace OverwatchWebAPI.Controllers
{
    public class REPORTINCIDENTController : ApiController
    {
        public IEnumerable<REPORTINCIDENT> GetReportedIncidents()
        {
            using (ReidiusDBEntities3 entities = new ReidiusDBEntities3())
            {
                return entities.REPORTINCIDENT.ToList();
            }
        }
        public REPORTINCIDENT GetReportIncidents(int id)
        {
            using (ReidiusDBEntities3 enteties = new ReidiusDBEntities3())
            {
                return enteties.REPORTINCIDENT.FirstOrDefault(e => e.reportIncidentID == id);
            }
        }
        public HttpResponseMessage Get(string status)
        {
            using (ReidiusDBEntities3 enteties = new ReidiusDBEntities3())
            {
                switch (status)
                {
                    case "Open":
                        return Request.CreateResponse(HttpStatusCode.OK, enteties.REPORTINCIDENT.Where(e => e.status == "Open").ToList());

                    case "InProgress":
                        return Request.CreateResponse(HttpStatusCode.OK, enteties.REPORTINCIDENT.Where(e => e.status == "InProgress").ToList());

                    case "Closed":
                        return Request.CreateResponse(HttpStatusCode.OK, enteties.REPORTINCIDENT.Where(e => e.status == "Closed").ToList());

                    default:
                        return Request.CreateResponse(HttpStatusCode.BadRequest, "Status value must be Open, InProgress, or Closed");
                }
            }
        }
        public void Post([FromBody]REPORTINCIDENT reportIncident)
        {
            try
            {
                using (ReidiusDBEntities3 entities = new ReidiusDBEntities3())
                {
                    entities.REPORTINCIDENT.Add(reportIncident);
                    entities.SaveChanges();
                }
            }


            catch (Exception ex)
            {

            }

        }
    }
}
