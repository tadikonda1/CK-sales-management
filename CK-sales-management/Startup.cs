using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CK_sales_management.Startup))]
namespace CK_sales_management
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
