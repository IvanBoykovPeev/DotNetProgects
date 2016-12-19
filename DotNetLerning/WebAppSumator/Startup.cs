using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppSumator.Startup))]
namespace WebAppSumator
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
