using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyHealthyBlog.Startup))]
namespace MyHealthyBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
