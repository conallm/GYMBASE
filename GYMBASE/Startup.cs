using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GYMBASE.Startup))]
namespace GYMBASE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
