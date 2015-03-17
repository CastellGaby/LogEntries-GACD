using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LogEntries.Startup))]
namespace LogEntries
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
