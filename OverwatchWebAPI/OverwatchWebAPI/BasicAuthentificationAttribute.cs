using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading;
using System.Security.Principal;

namespace OverwatchWebAPI
{
    //public class BasicAuthentificationAttribute : AuthorizationFilterAttribute
    //{
    ////    public override void OnAuthorization(HttpActionContext actionContext)
    ////    {
    ////        // IF THE HEADER IS NOT PRESENT WE KNOW THAT THE USERS DIDN'T SEND THEIR CREDENTIALS
    ////        if(actionContext.Request.Headers.Authorization == null)
    ////        {
    ////            actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
    ////        }
    ////        else
    ////        {
    ////            // what will be passed is the username and password encoded in a base 64 encoded
    ////            string authentificationToken = actionContext.Request.Headers.Authorization.Parameter;
    ////            // decoding
    ////            string decodedAuthentificationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authentificationToken));
    ////            string[] usernamePasswordArray = decodedAuthentificationToken.Split(':');
    ////            string username = usernamePasswordArray[0]; 
    ////            string password = usernamePasswordArray[1];

    ////            //if(LoginSecurity.Login(username, password))
    ////            //{
    ////            //    Thread.CurrentPrincipal = new GenericPrincipal(new  GenericIdentity(username), null);
    ////            //}
    ////            else //if username and password don't match
    ////            {
    ////                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
    ////            }

    ////        }
    ////    }
    ////}
}