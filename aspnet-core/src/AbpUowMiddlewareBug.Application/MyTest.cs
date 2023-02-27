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
        return "success"; // it returns HTTP 200 with no content if the handler throws
    }

    public async Task<string> DistributedAsync()
    {
        await _distributedEventBus.PublishAsync(new MyEto());
        return "success"; // it returns HTTP 200 with no content if the handler throws
    }
}

[Serializable]
public record MyEto;

public class MyDistributedEventHandler : ITransientDependency,
    ILocalEventHandler<MyEto>, IDistributedEventHandler<MyEto>
{
    public virtual Task HandleEventAsync(MyEto eventData)
    {
        Console.WriteLine("Bye");
        throw new AbpException("Bye");
    }
}