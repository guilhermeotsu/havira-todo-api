namespace Havira.Todo.Domain.Entities;

/// <summary>
/// Defines the interface for representation of a User on the system.
/// </summary>
public interface IUser
{
    
    /// <summary>
    /// Gets the unique identifier of the user.
    /// </summary>
    /// <returns>The Title of Todo as string.</returns>
    public string Id { get; }
}