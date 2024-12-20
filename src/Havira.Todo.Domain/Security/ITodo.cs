namespace Havira.Todo.Domain.Security;

/// <summary>
/// Defines the interface for representation of a Todo on the system.
/// </summary>
public interface ITodo
{
    /// <summary>
    /// Gets the unique identifier of the user.
    /// </summary>
    /// <returns>The Title of Todo as string.</returns>
    public string Id { get; }

    /// <summary>
    /// Gets the Title of the Todo.
    /// </summary>
    /// <returns>The Title of Todo as string.</returns>
    public string Title { get; }

    /// <summary>
    /// Gets the Description of the Todo.
    /// </summary>
    /// <returns>The Description of Todo as string.</returns>
    public string Description { get; }

    /// <summary>
    /// Gets the date when a Todo was created.
    /// </summary>
    /// <returns>The CreatedAt of Todo as string.</returns>
    public string CreatedAt { get; }

    /// <summary>
    /// Gets the date when a Todo was completed.
    /// </summary>
    /// <returns>The CompletedAt of Todo as string.</returns>
    public string CompletedAt { get; }
}
