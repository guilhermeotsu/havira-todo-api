using System.Security.Principal;

namespace Havira.Todo.Application.Todos.CreateTodo;

public class CreateTodoResult
{
    /// <summary>
    /// Get or Set ID of a Todo
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Get or Set  Title of a Todo
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Get or Set  Description of a Todo
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Get or Set UserId of a Todo
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Get or Set CreatedAt of a Todo
    /// </summary>
    public DateTime CreateAt { get; set; }
    
    /// <summary>
    /// Get or Set Completed? of a Todo
    /// </summary>
    public DateTime? CompletedAt { get; set; }
}