using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OverwatchDataAccess;
namespace OverwatchWebAPI
{
    public class LoginSecurity
    {
        // checks if the passed login details corrosponds with the details on the database.
        public static bool Login(int loginID, string password)
        {
            using (ReidiusDBEntities10 entities = new ReidiusDBEntities10())
            {
                return entities.LOGINs.Any(LOGIN => LOGIN.loginID.Equals(loginID) && LOGIN.password == password);
            }
        }
    }
}