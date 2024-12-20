using MediatR;

namespace Havira.Todo.Application.Todos.GetTodo;

public class GetTodoHandle : IRequestHandler<GetTodoCommand, GetTodoResult>
{
    /// <summary>
    /// Handles the GetTodoCommand request
    /// </summary>
    /// <param name="request">The GetTodoCommand</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Todo details if found</returns>
    /// <exception cref="NotImplementedException"></exception>
    public async Task<GetTodoResult> Handle(GetTodoCommand request, CancellationToken cancellationToken)
    {
        // validate the request with fluentvalidation
        // if is not valid throw an exception
        
        // get the todo from database
        // if is null throw an exception
        
        // if all it's use automapper and returns the todo
        throw new NotImplementedException();
    }
}
