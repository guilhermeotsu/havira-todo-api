using FluentValidation;
using Havira.Todo.Domain.Entities;

namespace Havira.Todo.Domain.Validation;

public class TodoValidation : AbstractValidator<Havira.Todo.Domain.Entities.Todo>
{
    public TodoValidation()
    {
        RuleFor(todo => todo.Title)
            .NotEmpty()
            .MaximumLength(255).WithMessage("Title cannot be longer than 255 characteres");

        RuleFor(todo => todo.Description)
            .NotEmpty()
            .MaximumLength(2048).WithMessage("Description cannot be longer than 2048 characteres");
    }
}
