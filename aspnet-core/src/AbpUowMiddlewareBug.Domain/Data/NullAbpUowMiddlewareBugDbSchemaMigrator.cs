using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpUowMiddlewareBug.Data;

/* This is used if database provider does't define
 * IAbpUowMiddlewareBugDbSchemaMigrator implementation.
 */
public class NullAbpUowMiddlewareBugDbSchemaMigrator : IAbpUowMiddlewareBugDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
