using Volo.Abp.Modularity;

namespace AbpUowMiddlewareBug;

[DependsOn(
    typeof(AbpUowMiddlewareBugApplicationModule),
    typeof(AbpUowMiddlewareBugDomainTestModule)
    )]
public class AbpUowMiddlewareBugApplicationTestModule : AbpModule
{

}
