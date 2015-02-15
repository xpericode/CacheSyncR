using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(WebApiDataAdmin.App_Start.Startup))]

namespace WebApiDataAdmin.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}