using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SoftUhi.Ajax.App.Startup))]
namespace SoftUhi.Ajax.App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
