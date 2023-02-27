using AbpUowMiddlewareBug.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpUowMiddlewareBug.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpUowMiddlewareBugEntityFrameworkCoreModule),
    typeof(AbpUowMiddlewareBugApplicationContractsModule)
    )]
public class AbpUowMiddlewareBugDbMigratorModule : AbpModule
{

}
