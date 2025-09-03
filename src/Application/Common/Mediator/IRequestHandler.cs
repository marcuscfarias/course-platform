namespace Application.Common.Mediator;

public interface IRequestHandler<TRequest, TResponse> : IRequest<TResponse> where TRequest : IRequest<TResponse>
{
    Task<TResponse> HandleAsync(TRequest request, CancellationToken cancellationToken = default);
}