using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTestGround.Configuration;

namespace AbpTestGround.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpTestGroundWebCoreModule))]
    public class AbpTestGroundWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpTestGroundWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpTestGroundWebHostModule).GetAssembly());
        }
    }
}
