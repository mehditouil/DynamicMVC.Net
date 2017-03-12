using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OrderEntryDemo.Startup))]
namespace OrderEntryDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
