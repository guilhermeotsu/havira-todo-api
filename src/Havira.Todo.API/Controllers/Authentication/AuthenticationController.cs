using AutoMapper;
using Havira.Todo.API.Common;
using Havira.Todo.API.Controllers.Authentication.Authenticate;
using Havira.Todo.Application.Authentication;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Havira.Todo.API.Controllers.Authentication;

[ApiController]
[Route("api/auth")]
[AllowAnonymous]
public class AuthenticationController : BaseController
{
   private readonly IMapper _mapper;
   private readonly IMediator _mediator;

   public AuthenticationController(IMapper mapper, IMediator mediator)
   {
      _mapper = mapper;
      _mediator = mediator;
   }

   [HttpPost] 
   public async Task<IActionResult> AuthenticateUser([FromBody] AuthenticateUserRequest request, CancellationToken cancellationToken)
   {
      var validator = new AuthenticateUserRequestValidator();
      var validationResult = await validator.ValidateAsync(request, cancellationToken);

      if (!validationResult.IsValid)
         return BadRequest(validationResult.ToDictionary());

      var command = _mapper.Map<AuthenticateUserCommand>(request);
      var response = await _mediator.Send(command, cancellationToken);

      return Ok(new ApiResponseWithData<AuthenticateUserResponse>
      {
         Success = true,
         Message = "User authenticated successfully",
         Data = _mapper.Map<AuthenticateUserResponse>(response)
      });
   }
}