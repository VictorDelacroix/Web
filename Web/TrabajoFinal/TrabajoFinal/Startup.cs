using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrabajoFinal.Startup))]
namespace TrabajoFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
