using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(CurveManagement.Startup))]

namespace CurveManagement
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888
        }
    }
}
