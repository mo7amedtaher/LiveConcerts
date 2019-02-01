using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LiveConcerts.Startup))]
namespace LiveConcerts
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
