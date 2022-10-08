namespace MediatRSample.Notifications;

public record UserCreated : INotification
{
    public User User { get; init; } = User.Empty;
}