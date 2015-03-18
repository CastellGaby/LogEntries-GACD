using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace LogEntries.Models
{
    public class FilterLog:FilterAttribute, IActionFilter, IResultFilter, IExceptionFilter
    {

            private static ILog log = LogManager.GetLogger(typeof(FilterLog));

            public FilterLog()
            {
                log.Debug("Se ha Loggeado");
            }

            public void OnActionExecuting(ActionExecutingContext filterContext)
            {
                log.Debug("Se Ejecutó una acción");
            }

            public void OnActionExecuted(ActionExecutedContext filterContext)
            {
                log.Warn("Ejecutó la acción");
            }

            public void OnResultExecuting(ResultExecutingContext filterContext)
            {
                log.Debug("Se Proceso el Resultado");
            }

            public void OnResultExecuted(ResultExecutedContext filterContext)
            {
                log.Warn("Procesó el Resultado");
            }

            public void OnException(ExceptionContext filterContext)
            {
                log.Error("Ha surgido un error.");
            }

    }
 
}