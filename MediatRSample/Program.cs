// See https://aka.ms/new-console-template for more information
using System.Reflection;

Console.WriteLine("Hello, World!");

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((_, services) =>
        services.AddMediatR(Assembly.GetExecutingAssembly()))
    .Build();

IMediator mediator = host.Services.GetRequiredService<IMediator>();

User user = await mediator.Send(new GetUser { Id = Guid.NewGuid() });

Console.WriteLine($"{user.FirstName} {user.LastName}");

await mediator.Publish(new UserCreated { User = user});

Console.WriteLine("End program");

//await host.RunAsync();