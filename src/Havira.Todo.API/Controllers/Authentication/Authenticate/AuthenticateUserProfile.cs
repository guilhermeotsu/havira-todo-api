using AutoMapper;

namespace Havira.Todo.API.Controllers.Authentication.Authenticate;

/// <summary>
/// AutoMapper profile for authentication-related mappings
/// </summary>
public sealed class AuthenticateUserProfile : Profile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthenticateUserProfile"/> class
    /// </summary>
    public AuthenticateUserProfile()
    {
        CreateMap<Domain.Entities.User, AuthenticateUserResponse>()
            .ForMember(dest => dest.Token, opt => opt.Ignore());
    }
}
