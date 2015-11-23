using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ContosoUniversity.Startup))]
namespace ContosoUniversity
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}