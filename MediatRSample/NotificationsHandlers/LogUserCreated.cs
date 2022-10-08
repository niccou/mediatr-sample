namespace MediatRSample.NotificationsHandlers;

public class LogUserCreated : INotificationHandler<UserCreated>
{
    public Task Handle(UserCreated notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"LogUserCreated {notification.User.FirstName} {notification.User.LastName}");

        return Task.CompletedTask;
    }
}