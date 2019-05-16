using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMe.Startup))]
namespace VidlyMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
