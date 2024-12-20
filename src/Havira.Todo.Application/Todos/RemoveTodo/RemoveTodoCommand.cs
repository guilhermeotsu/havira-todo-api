using MediatR;

namespace Havira.Todo.Application.Todos.RemoveTodo;

public class RemoveTodoCommand : IRequest<RemoveTodoResult>
{
    /// <summary>
    /// Get's of Id of Todo
    /// </summary>
    public Guid Id { get;}
    
    /// <summary>
    /// Get's of UserID of Todo
    /// </summary>
    public Guid UserId { get;}
}