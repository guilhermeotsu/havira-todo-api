using Havira.Todo.Domain.Common;
using Havira.Todo.Domain.Security;
using Havira.Todo.Domain.Validation;

namespace Havira.Todo.Domain.Entities;

/// <summary>
/// Represents a todo in the system
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class Todo : BaseEntity, ITodo
{
    /// <summary>
    /// Gets the todo's title
    /// Must be a required
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets the todo's Description
    /// Must be a required
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets the todo's UserId who created
    /// Must be a required
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Gets the todo's when was created
    /// Must be a required
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets the todo's when was completed
    /// Must be a required
    /// </summary>
    public DateTime CompletedAt { get; set; }

    /// <summary>
    /// Gets the date when a Todo was created.
    /// </summary>
    /// <returns>The CreatedAt of Todo as string.</returns>
    string ITodo.CreatedAt => CreatedAt.ToString();

    /// <summary>
    /// Gets the date when a Todo was completed.
    /// </summary>
    /// <returns>The CompletedAt of Todo as string.</returns>
    string ITodo.CompletedAt => CompletedAt.ToString();

    /// <summary>
    /// Gets the unique identifier of the Todo.
    /// </summary>
    /// <returns>The Title of Todo as string.</returns>
    string ITodo.Id => Id.ToString();

    /// <summary>
    /// Performs validation of the todo entity using the TodoValidator rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <listheader>The validation includes checking:</listheader>
    /// <list type="bullet">Title length</list>
    /// <list type="bullet">Description length</list>
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validator = new TodoValidation();
        var result = validator.Validate(this);

        return new ValidationResultDetail(result);
    }

    /// <summary>
    /// Complete the Todo task
    /// Changes the completedAt to current date.
    /// </summary>
    public void Complete()
    {
        CompletedAt = DateTime.Now;
    }
}
