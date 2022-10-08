namespace MediatRSample.NotificationsHandlers;

public class CreateClientProfile : INotificationHandler<UserCreated>
{
    public async Task Handle(UserCreated notification, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Doing some stuff when UserCreated  {notification.User.FirstName} {notification.User.LastName}");
        await Task.Delay(2000);
        Console.WriteLine($"Stuff done {notification.User.FirstName} {notification.User.LastName}");
    }
}