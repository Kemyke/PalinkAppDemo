using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PalinkaAppDemo.Startup))]
namespace PalinkaAppDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
