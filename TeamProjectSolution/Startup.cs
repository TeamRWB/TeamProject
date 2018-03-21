using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamProjectSolution.Startup))]
namespace TeamProjectSolution
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
