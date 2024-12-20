using AutoMapper;
using Havira.Todo.Domain.Repostories;
using MediatR;

namespace Havira.Todo.Application.Todos.CreateTodo;

public class CreateTodoHandler : IRequestHandler<CreateTodoCommand, CreateTodoResult>
{
    private readonly ITodoRepository _todoRepository;
    private readonly IMapper _mapper;
    
    public CreateTodoHandler(ITodoRepository todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }
    
    /// <summary>
    /// Handles the CreateTodoCommand request
    /// </summary>
    /// <param name="request">The CreateTodoCommand</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Todo details with an ID</returns>
    public async Task<CreateTodoResult> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
    {
        var todo = _mapper.Map<Domain.Entities.Todo>(request);

        Domain.Entities.Todo? todoCreated = await _todoRepository.CreateTodoAsync(todo, cancellationToken);

        return _mapper.Map<CreateTodoResult>(todoCreated);
    }
}