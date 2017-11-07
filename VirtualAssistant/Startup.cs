using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VirtualAssistant.Startup))]
namespace VirtualAssistant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
