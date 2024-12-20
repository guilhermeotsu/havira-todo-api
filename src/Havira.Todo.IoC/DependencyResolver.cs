using Havira.Todo.IoC.Modules;
using Microsoft.AspNetCore.Builder;

namespace Havira.Todo.IoC;

public static class DepedencyResolver
{
    public static void RegisterDependencies(this WebApplicationBuilder builder)
    {
        new ApiModuleInitializer().Initialize(builder);
        new IocModuleResolver().Initialize(builder);
        new ApplicationResolver().Initialize(builder);
    }
}
