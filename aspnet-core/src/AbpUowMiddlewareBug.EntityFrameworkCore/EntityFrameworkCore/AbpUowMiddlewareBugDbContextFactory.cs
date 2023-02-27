using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpUowMiddlewareBug.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpUowMiddlewareBugDbContextFactory : IDesignTimeDbContextFactory<AbpUowMiddlewareBugDbContext>
{
    public AbpUowMiddlewareBugDbContext CreateDbContext(string[] args)
    {
        AbpUowMiddlewareBugEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<AbpUowMiddlewareBugDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new AbpUowMiddlewareBugDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpUowMiddlewareBug.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
