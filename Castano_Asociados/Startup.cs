using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Castano_Asociados.Startup))]
namespace Castano_Asociados
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
