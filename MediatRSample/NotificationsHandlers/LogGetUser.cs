namespace MediatRSample.NotificationsHandlers;

public class LogGetUser : INotificationHandler<GetUser>
{
    public Task Handle(GetUser notification, CancellationToken cancellationToken)
    {
        Log(notification);

        return Task.CompletedTask;
    }

    private async void Log(GetUser notification)
    {
        Console.WriteLine($"Logging GetUSer {notification.Id}");
        
        await Task.Delay(2000);

        Console.WriteLine($"Logged GetUSer {notification.Id}");
    }
}
