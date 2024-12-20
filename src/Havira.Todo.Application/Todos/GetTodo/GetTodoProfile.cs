using AutoMapper;

namespace Havira.Todo.Application.Todos.GetTodo;

/// <summary>
/// Profile for mapping between Todo entity and GetTodoResponse
/// </summary>
public class GetTodoProfile : Profile
{
    public GetTodoProfile()
    {
        CreateMap<Domain.Entities.Todo, GetTodoResult>();
        CreateMap<GetTodoCommand, GetTodoResult>();
    }
}