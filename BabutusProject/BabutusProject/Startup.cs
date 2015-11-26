using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BabutusProject.Startup))]
namespace BabutusProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
