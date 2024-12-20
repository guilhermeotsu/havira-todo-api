using AutoMapper;
using FluentValidation.Results;
using Havira.Todo.API.Common;
using Havira.Todo.API.Controllers.Todo.CreateTodo;
using Havira.Todo.API.Controllers.Todo.DeleteTodo;
using Havira.Todo.API.Controllers.Todo.GetTodo;
using Havira.Todo.API.Controllers.Todo.UpdateTodo;
using Havira.Todo.Application.Todos.CreateTodo;
using Havira.Todo.Application.Todos.GetTodo;
using Havira.Todo.Application.Todos.RemoveTodo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Havira.Todo.API.Controllers.Todo;

[ApiController]
[Route("api/[controller]")]
public class TodoController : BaseController
{
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public TodoController(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }

    /// <summary>
    /// Get a todo by user
    /// </summary>
    /// <param name="id">The Id of todo get request</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>The Get Todo details</returns>
    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<GetTodoResponse>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(List<ValidationFailure>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetTodo([FromRoute] Guid id, CancellationToken ct)
    {
        var request = new GetTodoRequest { Id = id, UserId = Guid.NewGuid() };
        var validator = new GetTodoRequestValidator();
        var validationResult = await validator.ValidateAsync(request, ct);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.ToDictionary());

        var command = _mapper.Map<GetTodoCommand>(request); 
        var response = await _mediator.Send(command, ct);

        return Ok(data: new ApiResponseWithData<GetTodoResponse>
        {
            Success = true,
            Message = "Todo retrieved successfully",
            Data = _mapper.Map<GetTodoResponse>(response)
        });
    }

    /// <summary>
    /// Creates a new todo
    /// </summary>
    /// <param name="request">The todo creation request</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>The created todo details</returns>
    [HttpPost]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateTodoResult>), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(List<ValidationFailure>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CreateTodo(
            [FromBody] CreateTodoRequest request,
            CancellationToken ct)
    {
        var validator = new CreateTodoRequestValidator();
        var validationResult = await validator.ValidateAsync(request, ct);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.ToDictionary());

        var createTodoCommand = _mapper.Map<CreateTodoCommand>(request);
        CreateTodoResult response = await _mediator.Send(createTodoCommand, ct);

        return Created(
                string.Empty,
                new ApiResponseWithData<CreateTodoResult>
                {
                    Success = true,
                    Message = "Todo Created successfully",
                    Data = response
                });
    }

    /// <summary>
    /// Update an todo
    /// </summary>
    /// <param name="id">The Id of an todo to update</param>
    /// <param name="request">The todo update request</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>The updated Todo details</returns>
    [HttpPatch("{id}")]
    [ProducesResponseType(typeof(ApiResponseWithData<CreateTodoResult>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(List<ValidationFailure>), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> UpdateTodo(
            [FromRoute] Guid id,
            [FromBody] UpdateTodoRequest request,
            CancellationToken ct)
    {
        request.Id = id;
        var validator = new UpdateTodoRequestValidator();
        var validationResult = await validator.ValidateAsync(request, ct);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.ToDictionary());

        var updateCommand = _mapper.Map<CreateTodoCommand>(request);
        CreateTodoResult result = await _mediator.Send(updateCommand, ct);

        return Ok(data: new ApiResponseWithData<CreateTodoResult>
                {
                    Success = true,
                    Message = "Todo Updated successfully",
                    Data = result
                });
    }

    /// <summary>
    /// Remove an todo
    /// </summary>
    /// <param name="id">The Id todo remove request</param>
    /// <param name="ct">Cancellation token</param>
    /// <returns>The updated Todo details</returns>
    [HttpDelete("{id}")]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> RemoveTodo([FromRoute] Guid id, CancellationToken ct)
    {
        var request = new RemoveTodoRequest { Id = id, UserId = Guid.NewGuid() };
        var validator = new RemoveTodoRequestValidator();
        var validationResult = await validator.ValidateAsync(request, ct);

        if (!validationResult.IsValid)
            return BadRequest(validationResult.ToDictionary());

        var command = _mapper.Map<RemoveTodoCommand>(request);
        RemoveTodoResult result = await _mediator.Send(command, ct);
        
       return Removed(success: result.IsRemoved);
    }
}
