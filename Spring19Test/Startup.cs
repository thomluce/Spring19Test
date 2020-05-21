using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Spring19Test.Startup))]
namespace Spring19Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
