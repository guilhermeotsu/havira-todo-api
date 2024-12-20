using Havira.Todo.Domain.Common;
using Havira.Todo.Domain.Validation;

namespace Havira.Todo.Domain.Entities;

/// <summary>
/// Represents a User in the system
/// This entity follows domain-driven design principles and includes business rules validation.
/// </summary>
public class User : BaseEntity, IUser
{
    /// <summary>
    /// Gets the email of the User.
    /// </summary>
    /// <returns>The Title of Todo as string.</returns>
    public string Email { get; set; } = string.Empty;
    
    /// <summary>
    /// Gets the Password User.
    /// </summary>
    /// <returns>The Title of Todo as string.</returns>
    public string Password { get; set; } = string.Empty;

    string IUser.Id => Id.ToString();
    
    /// <summary>
    /// Navigation property for related Todos
    /// </summary>
    public ICollection<Todo> Todos { get; set; }
    
    /// <summary>
    /// Performs validation of the user entity using the UserValidation rules.
    /// </summary>
    /// <returns>
    /// A <see cref="ValidationResultDetail"/> containing:
    /// - IsValid: Indicates whether all validation rules passed
    /// - Errors: Collection of validation errors if any rules failed
    /// </returns>
    /// <remarks>
    /// <list type="bullet">Email format</list>
    /// <list type="bullet">Password complexity requirements</list>
    /// </remarks>
    public ValidationResultDetail Validate()
    {
        var validation = new UserValidation();

        var result = validation.Validate(this);
        return new ValidationResultDetail(result);
    }
}