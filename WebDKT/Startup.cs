using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebDKT.Startup))]
namespace WebDKT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
