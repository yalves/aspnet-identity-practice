using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EDCT1T.ProjetoIdentity.Presentation.WebApp.Startup))]
namespace EDCT1T.ProjetoIdentity.Presentation.WebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
