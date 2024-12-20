namespace Havira.Todo.Application.User.GetUser;

public class GetUserResult
{
    /// <summary>
    /// The unique identifier of the user
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// The user's email address
    /// </summary>
    public string Email { get; set; } = string.Empty;
   
    /// <summary>
    /// The user's password address
    /// </summary>
    public string Password { get; set; } = string.Empty;
}
