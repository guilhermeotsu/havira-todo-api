namespace Havira.Todo.Application.Authentication;

/// <summary>
/// Represents the response after authenticating a user
/// </summary>
public sealed class AuthenticateUserResult
{
    /// <summary>
    /// Gets or sets the authentication token
    /// </summary>
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user's unique identifier
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Gets or sets the user's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;
}