using Havira.Todo.Domain.Repostories;
using Havira.Todo.ORM;
using Havira.Todo.ORM.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Havira.Todo.IoC.Modules;

public class IocModuleResolver : IModuleInitializer
{
    public void Initialize(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<DbContext>(provider => provider.GetRequiredService<DefaultContext>());
        builder.Services.AddScoped<ITodoRepository, TodoRepository>();
    }
}