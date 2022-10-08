namespace MediatRSample.Requests;

public record GetUser : IRequest<User>, INotification
{
    public Guid Id { get; init; } = Guid.Empty;
}