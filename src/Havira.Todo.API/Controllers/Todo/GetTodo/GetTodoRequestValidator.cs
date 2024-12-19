using FluentValidation;

namespace Havira.Todo.API.Controllers.Todo.GetTodo;

/// <summary>
/// Validator for GetTodoRequest that defines validation rules for todo get.
/// </summary>
public class GetTodoRequestValidator : AbstractValidator<GetTodoRequest>
{

    /// <summary>
    /// Initializes a new instance of the GetTodoRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - TodoId: Required
    /// </remarks>
    public GetTodoRequestValidator()
    {
        RuleFor(todo => todo.TodoId)
            .NotEmpty().WithMessage("Title is required");
    }
}

