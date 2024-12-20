using AutoMapper;
using Havira.Todo.Application.Common;
using Havira.Todo.Domain.Repostories;
using MediatR;

namespace Havira.Todo.Application.User;

/// <summary>
/// Handler for processing CreateUserCommand requests
/// </summary>
public class CreateUserHandler : IRequestHandler<CreateUserCommand, CreateUserResult>
{
    private readonly IPasswordHasher _passwordHasher;
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public CreateUserHandler(IPasswordHasher passwordHasher, IUserRepository userRepository, IMapper mapper)
    {
        _passwordHasher = passwordHasher;
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<CreateUserResult> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<Domain.Entities.User>(request);
        user.Password = _passwordHasher.HashPassword(request.Password);

        var createdUser = await _userRepository.CreateAsync(user, cancellationToken);
        var result = _mapper.Map<CreateUserResult>(createdUser);
        return result;
    }
}