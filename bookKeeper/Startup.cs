using Microsoft.Owin;
using Owin;
using Microsoft.AspNetCore.Builder;

[assembly: OwinStartup(typeof(bookKeeper.Startup))]

namespace bookKeeper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
