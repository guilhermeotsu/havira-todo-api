namespace Havira.Todo.API.Controllers.User.CreateUser;

/// <summary>
/// API response model for CreateUser operation
/// </summary>
public class CreateUserResponse
{
    /// <summary>
    /// The unique identifier of the created user
    /// </summary>
    public Guid Id { get; set; }
 
    /// <summary>
    /// Email of the created user
    /// </summary>
    public string Email { get; set; } = string.Empty;
    
    /// <summary>
    /// Password of the created user
    /// </summary>
    public string Password { get; set; } = string.Empty;
} 