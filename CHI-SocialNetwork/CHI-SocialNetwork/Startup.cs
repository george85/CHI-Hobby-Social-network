using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CHI_SocialNetwork.Startup))]
namespace CHI_SocialNetwork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
