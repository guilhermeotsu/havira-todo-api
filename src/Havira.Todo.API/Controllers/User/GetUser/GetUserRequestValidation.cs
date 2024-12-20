using FluentValidation;

namespace Havira.Todo.API.Controllers.User.GetUser;

public class GetUserRequestValidation : AbstractValidator<GetUserRequest>
{
    /// <summary>
    /// The unique identifier of the created user
    /// </summary>
    public GetUserRequestValidation()
    {
        RuleFor(p => p.Id)
            .NotNull().WithMessage("Id is required");
    }
}