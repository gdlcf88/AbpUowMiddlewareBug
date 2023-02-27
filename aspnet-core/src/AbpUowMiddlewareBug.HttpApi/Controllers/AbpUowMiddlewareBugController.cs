using AbpUowMiddlewareBug.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpUowMiddlewareBug.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpUowMiddlewareBugController : AbpControllerBase
{
    protected AbpUowMiddlewareBugController()
    {
        LocalizationResource = typeof(AbpUowMiddlewareBugResource);
    }
}
