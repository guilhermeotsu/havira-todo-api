using AutoMapper;
using Havira.Todo.API.Controllers.Authentication.Authenticate;
using Havira.Todo.Application.Authentication;

namespace Havira.Todo.API.Mappings;

public class AuthenticateProfile : Profile
{
    public AuthenticateProfile()
    {
        CreateMap<AuthenticateUserRequest, AuthenticateUserCommand>();
    }
}