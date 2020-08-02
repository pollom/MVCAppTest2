using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAppTest.Startup))]
namespace MVCAppTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
