using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankApp.Filters
{
	public class DebugFilter : ActionFilterAttribute
	{
		//extracts controller name from the routedata
		//extracts the action name from the routedata
		//sets message
		//outputs a debug message at the start of the action
		public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllerName = filterContext.RouteData.Values["controller"];
            var actionName = filterContext.RouteData.Values["action"];
            var message = $"[OnActionExecuting] - {controllerName}.{actionName}";
            Debug.WriteLine(message);

            base.OnActionExecuting(filterContext);
        }

		/*
		public void OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

		public void OnResultExecuting(ResultExecutingContext filterContext)
        {

        }
		public void OnResultExecuted(ResultExecutedContext filterContext)
        {

        }
		*/
	}
}