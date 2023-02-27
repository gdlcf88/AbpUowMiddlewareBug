using AbpUowMiddlewareBug.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpUowMiddlewareBug;

[DependsOn(
    typeof(AbpUowMiddlewareBugEntityFrameworkCoreTestModule)
    )]
public class AbpUowMiddlewareBugDomainTestModule : AbpModule
{

}
