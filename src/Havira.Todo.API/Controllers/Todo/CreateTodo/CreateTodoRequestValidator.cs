using FluentValidation;

namespace Havira.Todo.API.Controllers.Todo.CreateTodo;

/// <summary>
/// Validator for CreateTodoRequest that defines validation rules for todo creation.
/// </summary>
public class CreateTodoRequestValidator : AbstractValidator<CreateTodoRequest>
{

    /// <summary>
    /// Initializes a new instance of the CreateTodoRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - Title: Required. Max Lenght must be 255
    /// - Description: Required
    /// - UserId: Required
    /// </remarks>
    public CreateTodoRequestValidator()
    {
        RuleFor(todo => todo.Title)
            .NotEmpty().WithMessage("Title is required")
            .MaximumLength(255).WithMessage("Max Lenght is 255");

        RuleFor(todo => todo.Description)
            .NotEmpty().WithMessage("Description is required")
            .MaximumLength(255 * 25);

        RuleFor(todo => todo.UserId)
            .NotEmpty().WithMessage("UserId is required");
    }
}

