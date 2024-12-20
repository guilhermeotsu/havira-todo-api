using AutoMapper;
using Havira.Todo.Application.Todos.CreateTodo;
using Havira.Todo.Domain.Repostories;
using MediatR;

namespace Havira.Todo.Application.Todos.UpdateTodo;

public class UpdateTodoHandler : IRequestHandler<CreateTodoCommand, CreateTodoResult>
{
    private readonly ITodoRepository _todoRepository;
    private readonly IMapper _mapper;

    public UpdateTodoHandler(ITodoRepository todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }

    /// <summary>
    /// Handles the UpdateTodoCommand request
    /// </summary>
    /// <param name="request">The UpdateTodoCommand</param>
    /// <param name="cancellationToken"></param>
    /// <returns>Todo details with an ID</returns>
    public async Task<CreateTodoResult> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
    {
        var todo = _mapper.Map<Domain.Entities.Todo>(request);
        Domain.Entities.Todo? result = await _todoRepository.UpdateTodoAsync(todo, cancellationToken);

        return _mapper.Map<CreateTodoResult>(result);
    }
}