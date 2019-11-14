using Microsoft.Extensions.Hosting;
using NetModular.Lib.Host.Web;

namespace NetModular.Module.Blog.WebHost
{
    public class Startup : StartupAbstract
    {
        public Startup(IHostEnvironment env) : base(env)
        {
        }
    }
}
