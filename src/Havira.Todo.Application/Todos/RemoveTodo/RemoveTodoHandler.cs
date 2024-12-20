using AutoMapper;
using Havira.Todo.Application.Todos.CreateTodo;
using Havira.Todo.Domain.Repostories;
using MediatR;

namespace Havira.Todo.Application.Todos.RemoveTodo;

public class RemoveTodoHandler : IRequestHandler<RemoveTodoCommand, RemoveTodoResult>
{
    private readonly ITodoRepository _todoRepository;
    private readonly IMapper _mapper;

    public RemoveTodoHandler(ITodoRepository todoRepository, IMapper mapper)
    {
        _todoRepository = todoRepository;
        _mapper = mapper;
    }

    public async Task<RemoveTodoResult> Handle(RemoveTodoCommand request, CancellationToken cancellationToken)
    {
        bool result = await _todoRepository.RemoveTodoAsync(request.Id, cancellationToken);

        return _mapper.Map<RemoveTodoResult>(result);
    }
}