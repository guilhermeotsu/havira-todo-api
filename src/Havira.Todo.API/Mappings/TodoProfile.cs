using AutoMapper;
using Havira.Todo.API.Controllers.Todo.CreateTodo;
using Havira.Todo.API.Controllers.Todo.DeleteTodo;
using Havira.Todo.API.Controllers.Todo.GetTodo;
using Havira.Todo.API.Controllers.Todo.UpdateTodo;
using Havira.Todo.Application.Todos.CreateTodo;
using Havira.Todo.Application.Todos.GetTodo;
using Havira.Todo.Application.Todos.RemoveTodo;

namespace Havira.Todo.API.Mappings;

public class TodoProfile : Profile
{
    public TodoProfile()
    {
        // GET
        CreateMap<GetTodoRequest, GetTodoCommand>();
        
        // CREATE
        CreateMap<CreateTodoRequest, CreateTodoCommand>();

        // PUT
        CreateMap<UpdateTodoRequest, CreateTodoCommand>();

        // REMOVE
        CreateMap<RemoveTodoRequest, RemoveTodoCommand>();
    } 
}