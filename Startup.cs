using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab10.Startup))]
namespace lab10
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
