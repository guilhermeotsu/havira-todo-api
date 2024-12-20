using AutoMapper;
using Havira.Todo.Application.Todos.CreateTodo;

namespace Havira.Todo.Application.Todos.RemoveTodo;

public class RemoveTodoProfile : Profile
{
    public RemoveTodoProfile()
    {
        CreateMap<RemoveTodoResult, bool>();
    }
}