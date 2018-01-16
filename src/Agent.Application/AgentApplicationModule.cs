using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Agent.Authorization;

namespace Agent
{
    [DependsOn(
        typeof(AgentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AgentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AgentAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AgentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
