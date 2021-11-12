using Microsoft.Owin;
using Owin;
using System.Data.Entity;
[assembly: OwinStartupAttribute(typeof(EntityFrameWork.Startup))]
namespace EntityFrameWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
