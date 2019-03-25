using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTestGround.Authorization;

namespace AbpTestGround
{
    [DependsOn(
        typeof(AbpTestGroundCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpTestGroundApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpTestGroundAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpTestGroundApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
