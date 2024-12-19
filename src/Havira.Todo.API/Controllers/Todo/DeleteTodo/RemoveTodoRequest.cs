namespace Havira.Todo.API.Controllers.Todo.DeleteTodo;

/// <summary>
/// Represents a request to delete a Todo in the system.
/// </summary>
public class RemoveTodoRequest
{
    /// <summary>
    /// Gets or Sets the id of the todo.
    /// </summary>
    public Guid TodoId { get; set; }
}
