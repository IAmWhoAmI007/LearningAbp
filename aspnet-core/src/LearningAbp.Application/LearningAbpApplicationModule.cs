using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LearningAbp.Authorization;

namespace LearningAbp
{
    [DependsOn(
        typeof(LearningAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LearningAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LearningAbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LearningAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
