using Havira.Todo.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Havira.Todo.IoC.Modules;

public class ApiModuleInitializer : IModuleInitializer
{
    public void Initialize(WebApplicationBuilder builder)
    {
        builder.Services.AddControllers();
        builder.Services.AddHealthChecks();
        builder.Services.AddEndpointsApiExplorer();
    }
}
