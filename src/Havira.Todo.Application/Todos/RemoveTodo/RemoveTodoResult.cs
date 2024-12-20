using MediatR;

namespace Havira.Todo.Application.Todos.RemoveTodo;

public class RemoveTodoResult
{
    /// <summary>
    /// Get or Set IsRemoved Todo
    /// </summary>
    public bool IsRemoved { get; set; }
}