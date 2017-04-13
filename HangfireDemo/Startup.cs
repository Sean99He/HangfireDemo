using Hangfire;
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
            GlobalConfiguration.Configuration.UseSqlServerStorage("Data Source=.;Initial Catalog=Test;Integrated Security=True");
            app.UseHangfireServer();
            app.UseHangfireDashboard();
            
        }
    }
}
