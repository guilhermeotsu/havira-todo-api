using AutoMapper;
using Havira.Todo.API.Controllers.User.CreateUser;
using Havira.Todo.API.Controllers.User.GetUser;
using Havira.Todo.Application.User;
using Havira.Todo.Application.User.GetUser;

namespace Havira.Todo.API.Mappings;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<GetUserRequest, GetUserCommand>();
        CreateMap<CreateUserRequest, CreateUserCommand>();
    }
}