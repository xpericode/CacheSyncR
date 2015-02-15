using System.Web.Http;

namespace WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            XperiCode.CacheSyncR.Proxy.Connect("http://localhost:58939/");
        }
    }
}
