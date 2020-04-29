using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OverwatchDataAccess;

namespace OverwatchWebAPI.Controllers
{
    public class STUDENTController : ApiController
    {
        public IEnumerable<STUDENT> GetAllStudents()
        {
            using (ReidiusDBEntities1 entities = new ReidiusDBEntities1())
            {
                return entities.STUDENT.ToList();
            }
        }
   public STUDENT GetStudent(int id)
        {
            using (ReidiusDBEntities1 enteties = new ReidiusDBEntities1())
            {
                return enteties.STUDENT.FirstOrDefault(e => e.studentID == id);
            }
        }
        public void Post([FromBody]STUDENT student)
        {
            try
            {
                using (ReidiusDBEntities1 entities = new ReidiusDBEntities1())
                {

                    entities.STUDENT.Add(student);
                    entities.SaveChanges();

                }

            }
               
            catch (Exception ex)
            {

            }
        }
    }
}
