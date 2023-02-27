using System.Threading.Tasks;

namespace AbpUowMiddlewareBug.Data;

public interface IAbpUowMiddlewareBugDbSchemaMigrator
{
    Task MigrateAsync();
}
