using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiConsumer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            XperiCode.CacheSyncR.Client.Connect("http://localhost:58922/", change =>
            {
                System.Diagnostics.Debug.WriteLine("{0} / {1} / {2}", change.Type, change.Key, change.Group);
            });
        }
    }
}
