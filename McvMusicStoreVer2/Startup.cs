using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(McvMusicStoreVer2.Startup))]
namespace McvMusicStoreVer2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
