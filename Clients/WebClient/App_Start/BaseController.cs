using BookCheap.Busines.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookCheap.Clients.WebClient.App_Start
{
    public class BaseController : Controller
    {
        [Dependency]
        public IUnitOfWork UnitOfWork { get; set; }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            if (!filterContext.IsChildAction && UnitOfWork.HasChanges())
                UnitOfWork.Commit();
        }
    }


}