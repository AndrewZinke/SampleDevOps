using BankApp.Filters;
using System.Web;
using System.Web.Mvc;

namespace BankApp
{
    public class FilterConfig
    {
        //applies filters to globally
        //actions and controllers
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new DebugFilter());
        }
    }
}
