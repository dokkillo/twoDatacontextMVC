using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Two_Datacontext_One_wEB.Startup))]
namespace Two_Datacontext_One_wEB
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
