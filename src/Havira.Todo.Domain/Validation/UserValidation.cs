using FluentValidation;
using Havira.Todo.Domain.Entities;

namespace Havira.Todo.Domain.Validation;

public class UserValidation : AbstractValidator<User>
{
    /// <summary>
    /// Initializes a new instance of the CreateUserRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Email: Must be valid format (using EmailValidator)
    /// - Password: Must meet security requirements (using PasswordValidator)
    /// </remarks>
    public UserValidation()
    {
        RuleFor(p => p.Email)
            .SetValidator(new EmailValidator());

        RuleFor(p => p.Password)
            .SetValidator(new PasswordValidator());
    }
}
