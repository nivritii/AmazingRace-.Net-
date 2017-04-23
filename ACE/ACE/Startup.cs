using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ACE.Startup))]
namespace ACE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
