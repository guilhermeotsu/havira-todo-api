using Havira.Todo.Application.User;
using MediatR;

namespace Havira.Todo.API.Controllers.User.GetUser;

public class GetUserRequest :IRequest<CreateUserResult>
{
    /// <summary>
    /// Represents a request to Get a User in the system.
    /// </summary>
    public Guid Id { get; set; }
}