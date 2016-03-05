using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KnockoutJsStudy.Startup))]
namespace KnockoutJsStudy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
