using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;


namespace LogEntries.Controllers
{
    public class LoginAttribute:ActionFilterAttribute , IExceptionFilter
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(LoginAttribute));
        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var s = filterContext.ActionDescriptor.ActionName;
            logger.Info(s);
            
        }


        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            
        }

        public void OnException(ExceptionContext filterContext)
        {
            //throw new NotImplementedException();
            return;
        }
    }
}