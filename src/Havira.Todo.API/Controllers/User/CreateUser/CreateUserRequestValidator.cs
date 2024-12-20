using FluentValidation;
using FluentValidation.Internal;
using Havira.Todo.Domain.Validation;
using Microsoft.Net.Http.Headers;

namespace Havira.Todo.API.Controllers.User.CreateUser;

/// <summary>
/// Validator for CreateUserRequest that defines validation rules for todo creation.
/// </summary>
public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
{
    /// <summary>
    /// Initializes a new instance of the CreateUserRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Email: Must be valid format (using EmailValidator)
    /// - Password: Must meet security requirements (using PasswordValidator)
    /// </remarks>
    public CreateUserRequestValidator()
    {
        RuleFor(p => p.Email)
            .SetValidator(new EmailValidator());

        RuleFor(p => p.Password)
            .SetValidator(new PasswordValidator());
    }
}