using FluentValidation;

namespace Havira.Todo.API.Controllers.Todo.DeleteTodo;

/// <summary>
/// Validator for GetTodoRequestValidator that defines validation rules for todo get.
/// </summary>
public class RemoveTodoRequestValidator : AbstractValidator<RemoveTodoRequest>
{

    /// <summary>
    /// Initializes a new instance of the DeleteTodoRequestValidator with defined validation rules.
    /// </summary>
    /// <remarks>
    /// Validation rules include:
    /// - TodoId: Required
    /// </remarks>
    public RemoveTodoRequestValidator()
    {
        RuleFor(todo => todo.TodoId)
            .NotEmpty().WithMessage("Id is required");
    }
}

