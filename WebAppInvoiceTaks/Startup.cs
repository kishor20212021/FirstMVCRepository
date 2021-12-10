using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppInvoiceTaks.Startup))]
namespace WebAppInvoiceTaks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
