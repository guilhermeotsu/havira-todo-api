using MediatR;

namespace Havira.Todo.Application.User;

/// <summary>
/// Command for creating a todo by their ID
/// </summary>
public record CreateUserCommand : IRequest<CreateUserResult>
{
    /// <summary>
    /// Get's the Id of a User
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Get's the Email of a User
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Get's the Password of a User
    /// </summary>
    public string Password { get; set; } = string.Empty;
}