namespace Havira.Todo.API.Controllers.Todo.CreateTodo;

/// <summary>
/// Represents a response to create a new Todo in the system.
/// </summary>
public class CreateTodoResponse : CreateTodoRequest
{
    /// <summary>
    /// Gets or sets the Id. Must be required
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Gets or sets the CreateDate. Must be required
    /// </summary>
    public DateTime CreateDate { get; set; }
}

