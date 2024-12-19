namespace Havira.Todo.Application.Todos.GetTodo;

/// <summary>
/// Response model for GetTodo operation
/// </summary>
public class GetTodoResult
{
    /// <summary>
    /// ID of the Todo
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    ///  The Title of Todo
    /// </summary>
    public string Title { get; set; } = string.Empty;
    
    /// <summary>
    /// The Description of Todo
    /// </summary>
    public string Description { get; set; } = string.Empty;
    
    /// <summary>
    /// The user's Id in the system
    /// </summary>
    public Guid UserId { get; set; }
    
    /// <summary>
    /// The Date when Todo was created
    /// </summary>
    public DateTime CreateDate { get; set; }
    
    /// <summary>
    /// The Date when Todo was completed
    /// </summary>
    public DateTime? CompletedDate { get; set; } = null;
}
