using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EventBus;
using Volo.Abp.EventBus.Distributed;
using Volo.Abp.EventBus.Local;

namespace AbpUowMiddlewareBug;

public class MyTestAppService : ApplicationService
{
    private readonly ILocalEventBus _localEventBus;
    private readonly IDistributedEventBus _distributedEventBus;

    public MyTestAppService(
        ILocalEventBus localEventBus,
        IDistributedEventBus distributedEventBus)
    {
        _localEventBus = localEventBus;
        _distributedEventBus = distributedEventBus;
    }
    
    public async Task<string> LocalAsync()
    {
        await _localEventBus.PublishAsync(new MyEto());
        return "success";
    }
    
    public async Task<string> DistributedAsync()
    {
        await _distributedEventBus.PublishAsync(new MyEto());
        return "success";
    }
}

[Serializable]
public class MyEto
{
}

public class MyLocalEventHandler : ILocalEventHandler<MyEto>, ITransientDependency
{
    public virtual Task HandleEventAsync(MyEto eventData)
    {
        throw new AbpException("Bye");
    }
}

public class MyDistributedEventHandler : IDistributedEventHandler<MyEto>, ITransientDependency
{
    public virtual Task HandleEventAsync(MyEto eventData)
    {
        throw new AbpException("Bye");
    }
}