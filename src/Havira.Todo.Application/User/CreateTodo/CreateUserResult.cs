namespace Havira.Todo.Application.User;

/// <summary>
/// Represents the response returned after successfully creating a new user.
/// </summary>
/// <remarks>
/// This response contains the unique identifier of the newly created user,
/// which can be used for subsequent operations or reference.
/// </remarks>
public class CreateUserResult
{
    /// <summary>
    /// Get or Set ID of a user
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Get or Set Email of a user
    /// </summary>
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Get or Set Email of a user
    /// </summary>
    public string Password { get; set; } = string.Empty;
}