using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(McvMusicStore.Startup))]
namespace McvMusicStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
