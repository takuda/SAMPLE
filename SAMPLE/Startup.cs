using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SAMPLE.Startup))]
namespace SAMPLE
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
