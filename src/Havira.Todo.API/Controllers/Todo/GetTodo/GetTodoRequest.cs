namespace Havira.Todo.API.Controllers.Todo.GetTodo;

/// <summary>
/// Represents a request to get an Todo in the system.
/// </summary>
public class GetTodoRequest
{
    /// <summary>
    /// Gets or Sets the id of the todo.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or Sets the id of the UserId.
    /// </summary>
    public Guid UserId { get; set; }
}
