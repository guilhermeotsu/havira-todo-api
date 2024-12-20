using Havira.Todo.Application.User;
using MediatR;

namespace Havira.Todo.API.Controllers.User.CreateUser;

/// <summary>
/// Represents a request to create a new User in the system.
/// </summary>
public class CreateUserRequest : IRequest<CreateUserResult>
{
    /// <summary>
    /// Get's the Email of a User
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Get's the Password of a User
    /// </summary>
    public string Password { get; set; } = string.Empty;
}