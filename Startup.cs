using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MindMap.Startup))]
namespace MindMap
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
