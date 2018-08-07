using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Niit.Ot.Startup))]
namespace Niit.Ot
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
