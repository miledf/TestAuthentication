using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

namespace TesteAuthentication.App_Start
{
    public class ApiAuthenticationFilter : GenericAuthenticationFilter
    {
        public ApiAuthenticationFilter()
        {
        }

        /// <summary>
        /// AuthenticationFilter constructor with isActive parameter
        /// </summary>
        /// <param name="isActive"></param>
        public ApiAuthenticationFilter(bool isActive)
            : base(isActive)
        {
        }

        /// <summary>
        /// Protected overriden method for authorizing user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        protected override bool OnAuthorizeUser(string username, string password, HttpActionContext actionContext)
        {
            if (username == "admin" && password == "admin")
                return true;

            //var provider = actionContext.ControllerContext.Configuration
            //                   .DependencyResolver.GetService(typeof(IUserServices)) as IUserServices;
            //if (provider != null)
            //{
            //    var userId = provider.Authenticate(username, password);
            //    if (userId > 0)
            //    {
            //        var basicAuthenticationIdentity = Thread.CurrentPrincipal.Identity as BasicAuthenticationIdentity;
            //        if (basicAuthenticationIdentity != null)
            //            basicAuthenticationIdentity.UserId = userId;
            //        return true;
            //    }
            //}
            return false;
        }
    }
}
