using AutoMapper;

namespace Havira.Todo.Application.User.GetUser;

/// <summary>
/// Profile for mapping between User entity and CreateUserResponse
/// </summary>
public class GetUserProfile : Profile
{
    public GetUserProfile()
    {
        CreateMap<GetUserCommand, Domain.Entities.User>().ReverseMap();
    }
}