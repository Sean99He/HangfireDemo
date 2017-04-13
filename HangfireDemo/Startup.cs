using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HangfireDemo.Startup))]
namespace HangfireDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
