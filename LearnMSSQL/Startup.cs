using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnMSSQL.Startup))]
namespace LearnMSSQL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
