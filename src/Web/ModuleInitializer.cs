using Microsoft.AspNetCore.Builder;
#if NETSTANDARD2_0
using Microsoft.AspNetCore.Hosting;
#endif
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
#if NETCOREAPP3_0
using Microsoft.Extensions.Hosting;
#endif
using NetModular.Lib.Module.AspNetCore;

namespace NetModular.Module.Blog.Web
{
    public class ModuleInitializer : IModuleInitializer
    {
        /// <summary>
        /// 注入服务
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
        }

        /// <summary>
        /// 配置中间件
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
#if NETSTANDARD2_0
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
#elif NETCOREAPP3_0
        public void Configure(IApplicationBuilder app, IHostEnvironment env)
#endif
        {
        }

        /// <summary>
        /// 配置MVC功能
        /// </summary>
        /// <param name="mvcOptions"></param>
        public void ConfigureMvc(MvcOptions mvcOptions)
        {
            
        }
    }
}
