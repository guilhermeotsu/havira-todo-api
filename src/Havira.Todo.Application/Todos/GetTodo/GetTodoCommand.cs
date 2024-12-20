using MediatR;

namespace Havira.Todo.Application.Todos.GetTodo;

/// <summary>
/// Command for retrieving a todo by their ID
/// </summary>
public record GetTodoCommand : IRequest<GetTodoResult>
{
    /// <summary>
    /// The unique identifier of the todo to retrieve
    /// </summary>
    public Guid Id { get; }

    /// <summary>
    /// Initializes a new instance of GetTodoCommand
    /// </summary>
    /// <param name="id">The ID of the todo to retrieve</param>
    public GetTodoCommand(Guid id)
    {
        Id = id;
    }
}
