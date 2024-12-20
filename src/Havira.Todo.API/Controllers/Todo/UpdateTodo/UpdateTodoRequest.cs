using Havira.Todo.API.Controllers.Todo.CreateTodo;

namespace Havira.Todo.API.Controllers.Todo.UpdateTodo;

/// <summary>
/// Represents a request to update a Todo in the system.
/// </summary>
public class UpdateTodoRequest : CreateTodoRequest
{
    /// <summary>
    /// Get/Set of a ID of Todo
    /// </summary>
    public Guid Id { get; set; }
}
