using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdventuresInTDD_Part2.Startup))]
namespace AdventuresInTDD_Part2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
