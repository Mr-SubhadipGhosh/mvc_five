using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mymvc.Startup))]
namespace mymvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
