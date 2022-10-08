namespace MediatRSample.Models;

public record User
{
    public string FirstName { get; init; } = "";
    public string LastName { get; init; } = "";

    public static User Empty => new();
}