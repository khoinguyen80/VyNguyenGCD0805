using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VyNguyenGCD0805.Startup))]
namespace VyNguyenGCD0805
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
