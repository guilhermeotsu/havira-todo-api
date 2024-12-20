namespace Havira.Todo.Application.Todos.UpdateTodo;

public class UpdateTodoCommand : IRequestHandler<>
{
    private readonly ITodoRepository _todoRepository;
    private readonly IMapper _mapper;

    public GetTodoHandle(ITodoRepository todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }
 
    /// <summary>
    /// Handles the GetTodoCommand request
    /// </summary>
    /// <param name="request">The GetTodoCommand</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Todo details if found</returns>
    /// <exception cref="KeyNotFoundException">If not found the Todo</exception>
    public async Task<GetTodoResult> Handle(GetTodoCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Todo? todo = await _todoRepository.GetTodoAsync(request.Id, request.UserId, cancellationToken);

        if (todo is null)
            throw new KeyNotFoundException($"Todo with ID:{request.Id} and UserID:{request.UserId} not found");
        
        return _mapper.Map<GetTodoResult>(todo);
    }
}
