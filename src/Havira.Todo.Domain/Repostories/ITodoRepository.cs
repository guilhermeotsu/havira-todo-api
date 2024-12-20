namespace Havira.Todo.Domain.Repostories;

/// <summary>
/// Repository interface for Todo entity operations
/// </summary>
public interface ITodoRepository
{
    /// <summary>
    /// Creates a new todo in the repository
    /// </summary>
    /// <param name="todo"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Havira.Todo.Domain.Entities.Todo> CreateTodoAsync(Havira.Todo.Domain.Entities.Todo todo, CancellationToken cancellationToken);

    /// <summary>
    /// Gets a todo in the repository
    /// </summary>
    /// <param name="id">ID of a Todo</param>
    /// <param name="idUser">ID who created a Todo</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Havira.Todo.Domain.Entities.Todo> GetTodoAsync(Guid id, Guid idUser, CancellationToken cancellationToken);

    /// <summary>
    /// Gets a list of todo in the repository
    /// </summary>
    /// <param name="idUser">ID who created a Todo</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<IEnumerable<Havira.Todo.Domain.Entities.Todo>> GetTodoAsync(Guid idUser, CancellationToken cancellationToken);

    /// <summary>
    /// Updates a todo in the repository
    /// </summary>
    /// <param name="id">ID of a Todo</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<Havira.Todo.Domain.Entities.Todo > UpdateTodoAsync(Havira.Todo.Domain.Entities.Todo todo, CancellationToken cancellationToken);

    /// <summary>
    /// Removes a todo in the repository
    /// </summary>
    /// <param name="id">ID of a Todo</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> RemoveTodoAsync(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Completes a todo in the repository
    /// </summary>
    /// <param name="id">ID of a Todo</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    Task<bool> CompleteTodoAsync(Guid id, CancellationToken cancellationToken);
}
