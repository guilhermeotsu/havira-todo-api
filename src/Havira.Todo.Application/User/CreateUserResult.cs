namespace Havira.Todo.Application.User;

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