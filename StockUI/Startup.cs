using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StockUI.Startup))]
namespace StockUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
