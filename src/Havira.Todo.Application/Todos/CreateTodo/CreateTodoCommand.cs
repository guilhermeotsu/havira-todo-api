using MediatR;

namespace Havira.Todo.Application.Todos.CreateTodo;

public class CreateTodoCommand : IRequest<CreateTodoResult>
{
    /// <summary>
    /// Get's the Title of a Todo
    /// </summary>
    public string Title { get; }

    /// <summary>
    /// Get's the Description of a Todo
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// Get's the UserId of a Todo
    /// </summary>
    public Guid UserId { get; set; }
}