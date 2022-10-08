namespace MediatRSample.RequestsHanlders;

public class GenerateUserHandler : IRequestHandler<GenerateUser, User>
{
    private readonly Faker _faker;

    public GenerateUserHandler()
        => _faker = new Faker();

    public Task<User> Handle(GenerateUser _, CancellationToken cancellationToken)
        => Task.FromResult(new User
        {
            FirstName = _faker.Person.FirstName,
            LastName = _faker.Person.LastName,
        });
}