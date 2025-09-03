using Microsoft.Extensions.DependencyInjection;

namespace Application.Common.Mediator;

public class Mediator(IServiceProvider provider) : IMediator
{
    public Task<TResponse> SendAsync<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
    {
        var handlerType = typeof(IRequestHandler<,>).MakeGenericType(request.GetType(), typeof(TResponse));
        dynamic handler = provider.GetRequiredService(handlerType);
        return handler.HandleAsync((dynamic)request, cancellationToken);
    }
}