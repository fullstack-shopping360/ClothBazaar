using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothBazaar.Web.Startup))]
namespace ClothBazaar.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
