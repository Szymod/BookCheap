using BookCheap.Busines.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BookCheap.Clients.WebClient.Code
{
    [AttributeUsageAttribute( AttributeTargets.Class | AttributeTargets.Method, Inherited = true, AllowMultiple = false )]
    public class AdminAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (base.AuthorizeCore(httpContext))
            {
                var user = httpContext.Session["LoggedUser"];

                if (user != null && user is User && (user as User).IsAdmin)
                {
                    return true;
                }
            }

            return false;
        }

        protected override void HandleUnauthorizedRequest(System.Web.Mvc.AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAuthenticated)
            {
                filterContext.Result = new System.Web.Mvc.HttpStatusCodeResult(403);
            }
            else
            {
                base.HandleUnauthorizedRequest(filterContext);
            }
        }
    }
}