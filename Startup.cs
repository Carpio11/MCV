using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2021.Startup))]
namespace _2021
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
