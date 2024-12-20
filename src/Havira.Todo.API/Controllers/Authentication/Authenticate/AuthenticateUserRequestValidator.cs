using FluentValidation;
using Havira.Todo.Domain.Validation;

namespace Havira.Todo.API.Controllers.Authentication.Authenticate;

/// <summary>
/// Validator for AuthenticateUserRequest
/// </summary>
public class AuthenticateUserRequestValidator : AbstractValidator<AuthenticateUserRequest>
{
    /// <summary>
    /// Initializes validation rules for AuthenticateUserRequest
    /// </summary>
    public AuthenticateUserRequestValidator()
    {
        RuleFor(x => x.Email)
            .SetValidator(new EmailValidator());

        RuleFor(x => x.Password)
            .SetValidator(new PasswordValidator());
    }
}
