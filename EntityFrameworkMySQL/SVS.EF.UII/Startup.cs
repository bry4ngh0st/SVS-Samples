using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SVS.EF.UII.Startup))]
namespace SVS.EF.UII
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
