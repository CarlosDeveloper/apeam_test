using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Apeam1.Startup))]
namespace Apeam1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
