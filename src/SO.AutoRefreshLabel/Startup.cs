using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(SO.AutoRefreshLabel.Startup))]

namespace SO.AutoRefreshLabel
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // This maps the ~/signalr/hubs route
            app.MapSignalR();
        }
    }
}
