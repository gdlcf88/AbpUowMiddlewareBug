using System;
using System.Collections.Generic;
using System.Text;
using AbpUowMiddlewareBug.Localization;
using Volo.Abp.Application.Services;

namespace AbpUowMiddlewareBug;

/* Inherit your application services from this class.
 */
public abstract class AbpUowMiddlewareBugAppService : ApplicationService
{
    protected AbpUowMiddlewareBugAppService()
    {
        LocalizationResource = typeof(AbpUowMiddlewareBugResource);
    }
}
