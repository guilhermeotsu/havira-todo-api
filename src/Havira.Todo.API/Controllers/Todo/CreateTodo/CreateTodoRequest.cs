namespace Havira.Todo.API.Controllers.Todo.CreateTodo;

/// <summary>
/// Represents a request to create a new Todo in the system.
/// </summary>
public class CreateTodoRequest
{
    /// <summary>
    /// Gets or sets the title. Must be required
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the Description. Must be required
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or Sets the date when the Todo was completed.
    /// </summary>
    public DateTime? CompletedAt { get; set; } = null;

    /// <summary>
    /// Gets or Sets the id of the Todo account.
    /// </summary>
    public Guid UserId { get; set; }
}
