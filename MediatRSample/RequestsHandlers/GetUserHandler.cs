using MediatR.Pipeline;

namespace MediatRSample.RequestsHanlders;

public class GetUserHandler : IRequestHandler<GetUser, User>,IRequestPostProcessor<GetUser, User>
{
    private readonly IMediator _mediator;
    public GetUserHandler(IMediator mediator)
    {
        _mediator = mediator;
    }

    public Task<User> Handle(GetUser request, CancellationToken cancellationToken)
    {
        Console.WriteLine($"Request GetUser {request.Id}");

        return _mediator.Send(new GenerateUser());
    }

    public Task Process(GetUser request, User user, CancellationToken cancellationToken)
    {
        return Task.Run(() => _mediator.Publish(request));
    }
}