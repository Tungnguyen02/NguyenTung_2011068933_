using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenTung_2011068933.Startup))]
namespace NguyenTung_2011068933
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
