using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SilverScreenReviews.Startup))]
namespace SilverScreenReviews
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
