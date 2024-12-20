using AutoMapper;
using Havira.Todo.Application.Todos.CreateTodo;

namespace Havira.Todo.Application.User;


/// <summary>
/// Profile for mapping between User entity and CreateUserResponse
/// </summary>
public class CreateUserProfile : Profile
{
    public CreateUserProfile()
    {
        CreateMap<CreateUserCommand, Domain.Entities.User>().ReverseMap();
    }
}