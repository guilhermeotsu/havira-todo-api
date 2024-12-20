using Havira.Todo.Domain.Repostories;
using Havira.Todo.Domain.Security;

namespace Havira.Todo.ORM.Repositories;

public class TodoRepository : ITodoRepository
{
    public Task<Domain.Entities.Todo> CreateTodoAsync(Domain.Entities.Todo todo, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Domain.Entities.Todo> GetTodoAsync(Guid id, Guid idUser, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Domain.Entities.Todo>> GetTodoAsync(Guid idUser, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<Domain.Entities.Todo> UpdateTodoAsync(Domain.Entities.Todo todo, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> RemoveTodoAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> CompleteTodoAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}