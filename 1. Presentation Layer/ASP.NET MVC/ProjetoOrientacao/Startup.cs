using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjetoOrientacao.Startup))]
namespace ProjetoOrientacao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
