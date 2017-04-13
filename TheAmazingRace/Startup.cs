using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TheAmazingRace.Startup))]
namespace TheAmazingRace
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
