using Microsoft.AspNetCore.Builder;

namespace Havira.Todo.IoC;

public interface IModuleInitializer
{
    void Initialize(WebApplicationBuilder builder);
}
