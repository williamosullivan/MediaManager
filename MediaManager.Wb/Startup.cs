using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MediaManager.Wb.Startup))]
namespace MediaManager.Wb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
