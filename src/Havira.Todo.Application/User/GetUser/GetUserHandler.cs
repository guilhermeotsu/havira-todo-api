using AutoMapper;
using MediatR;

namespace Havira.Todo.Application.User.GetUser;

/// <summary>
/// Handler for processing GetUserCommand requests
/// </summary>
public class GetUserHandler : IRequestHandler<GetUserCommand, GetUserResult>
{
    private readonly IMapper _mapper;

    public GetUserHandler(IMapper mapper)
    {
        _mapper = mapper;
    }

    public Task<GetUserResult> Handle(GetUserCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}