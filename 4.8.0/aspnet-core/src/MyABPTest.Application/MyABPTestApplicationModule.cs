using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyABPTest.Authorization;

namespace MyABPTest
{
    [DependsOn(
        typeof(MyABPTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyABPTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyABPTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyABPTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
