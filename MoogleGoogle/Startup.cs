using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoogleGoogle.Startup))]
namespace MoogleGoogle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
