namespace Havira.Todo.API.Controllers.Authentication.Authenticate;

/// <summary>
/// Represents the response returned after user authentication
/// </summary>
public sealed class AuthenticateUserResponse
{
    /// <summary>
    /// Gets or sets the JWT token for authenticated user
    /// </summary>
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;   
}
