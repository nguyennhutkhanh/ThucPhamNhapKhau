using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThucPhamNhapKhau.Startup))]
namespace ThucPhamNhapKhau
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
