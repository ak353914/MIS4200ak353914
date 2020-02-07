using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MIS4200ak353914.Startup))]
namespace MIS4200ak353914
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
