using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Суматор.Startup))]
namespace Суматор
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
