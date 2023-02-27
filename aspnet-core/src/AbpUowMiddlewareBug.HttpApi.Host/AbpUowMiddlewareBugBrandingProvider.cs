using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpUowMiddlewareBug;

[Dependency(ReplaceServices = true)]
public class AbpUowMiddlewareBugBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpUowMiddlewareBug";
}
