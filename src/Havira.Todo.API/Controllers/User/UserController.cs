using AutoMapper;
using FluentValidation.Results;
using Havira.Todo.API.Common;
using Havira.Todo.API.Controllers.Todo.GetTodo;
using Havira.Todo.API.Controllers.User.CreateUser;
using Havira.Todo.API.Controllers.User.GetUser;
using Havira.Todo.Application.User;
using Havira.Todo.Application.User.GetUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Havira.Todo.API.Controllers.User;

[ApiController]
[Route("api/[controller]")]
public class UserController : BaseController
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public UserController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }
    
    /// <summary>
    /// Get a User by Id
    /// </summary>
    /// <param name="id">The Id of User</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The Get User details</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetUserResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(List<ValidationFailure>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetUser([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var request = new GetUserRequest { Id = id };
        var validator = new GetUserRequestValidation();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.ToDictionary());

        var command = _mapper.Map<GetUserCommand>(request);
        GetUserResult response = await _mediator.Send(command, cancellationToken);

        return Ok(new ApiResponseWithData<GetUserResponse>
        {
            Success = true,
            Message = "User retrieved successfully",
            Data = _mapper.Map<GetUserResponse>(response)
        });
    }
    
    /// <summary>
    /// Creates a new User
    /// </summary>
    /// <param name="request">The User creation request</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created User details</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateUserResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(List<ValidationFailure>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request, CancellationToken cancellationToken)
    {
        var validator = new CreateUserRequestValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.ToDictionary());

        var command = _mapper.Map<CreateUserCommand>(request);
        CreateUserResult result = await _mediator.Send(command, cancellationToken);
        
        return Ok(new ApiResponseWithData<CreateUserResponse>
        {
            Success = true,
            Message = "User created successfully",
            Data = _mapper.Map<GetUserResponse>(result)
        });
    }
    
}