using AutoMapper;

namespace Havira.Todo.Application.Todos.CreateTodo;

/// <summary>
/// Profile for mapping between Todo entity and CreateUserResponse
/// </summary>
public class CreateTodoProfile : Profile
{
    public CreateTodoProfile()
    {
        CreateMap<CreateTodoCommand, Domain.Entities.Todo>();
        CreateMap<Domain.Entities.Todo, CreateTodoResult>();
    }
}