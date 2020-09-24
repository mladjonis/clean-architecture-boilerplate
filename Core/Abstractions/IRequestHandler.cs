namespace Core.Abstractions
{
    public interface IRequestHandler<TRequest, TResponse>
        where TRequest : struct
        where TResponse : struct
    {
        TResponse Handle(TRequest request);
    }
}
