using Havira.Todo.Domain.Repostories;
using Microsoft.EntityFrameworkCore;

namespace Havira.Todo.ORM.Repositories;


/// <summary>
/// Implementation of ITodoRepository using Entity Framework Core
/// </summary>
public class TodoRepository : ITodoRepository
{
    private readonly DefaultContext _context;
    
    /// <summary>
    /// Initializes a new instance of TodoRepository
    /// </summary>
    /// <param name="context">The database context</param>
    public TodoRepository(DefaultContext context)
    {
        _context = context;
    }
    
    /// <summary>
    /// Creates a new todo in the database
    /// </summary>
    /// <param name="todo">The todo to create</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The created todo</returns>
    public async Task<Domain.Entities.Todo?> CreateTodoAsync(Domain.Entities.Todo? todo, CancellationToken cancellationToken)
    {
        await _context.Todos.AddAsync(todo!, cancellationToken);
        await _context.SaveChangesAsync(cancellationToken);
        return todo;
    }
    
    /// <summary>
    /// Retrieves a todo by their unique identifier and idUser identifies
    /// </summary>
    /// <param name="id">The unique identifier of the todo</param>
    /// <param name="idUser">The unique identifier of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The todo if found, null otherwise</returns>
    public async Task<Domain.Entities.Todo?> GetTodoAsync(Guid id, Guid idUser, CancellationToken cancellationToken)
    {
        return await _context.Todos.FirstOrDefaultAsync(o=> o.Id == id && o.UserId == idUser, cancellationToken);
    }
    
    /// <summary>
    /// Retrieves a list of todo created by the user
    /// </summary>
    /// <param name="idUser">The unique identifier of the user</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list of todo if found</returns>
    public async Task<IEnumerable<Domain.Entities.Todo>> GetTodoAsync(Guid idUser, CancellationToken cancellationToken)
    {
        return await _context.Todos.Where(p => p.UserId == idUser).ToListAsync(cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Update a todo
    /// </summary>
    /// <param name="todo">The todo who will be updated</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The list of todo if found</returns>
    public async Task<Domain.Entities.Todo?> UpdateTodoAsync(Domain.Entities.Todo? todo, CancellationToken cancellationToken)
    {
        var existingEntity = await _context.Todos.FirstOrDefaultAsync(p => p.Id == todo!.Id, cancellationToken);
        if (existingEntity == null) return null;

        _context.Entry(existingEntity).CurrentValues.SetValues(todo!);

        await _context.SaveChangesAsync(cancellationToken);

        return todo;
    }

    /// <summary>
    /// Removes a todo
    /// </summary>
    /// <param name="id">The id of  todo who will be removed</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The boolean if todo was removed</returns>
    public async Task<bool> RemoveTodoAsync(Guid id, CancellationToken cancellationToken)
    {
        var todo = await _context.Todos.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
        if (todo is null) return false;

        _context.Todos.Remove(todo);
        await _context.SaveChangesAsync(cancellationToken);
        
        return true;
    }

    /// <summary>
    /// Completes a todo
    /// </summary>
    /// <param name="id">The id of  todo who will be completed</param>
    /// <param name="cancellationToken">Cancellation token</param>
    /// <returns>The boolean if todo was completed</returns>
    public async Task<bool> CompleteTodoAsync(Guid id, CancellationToken cancellationToken)
    {
        var todo = await _context.Todos.FirstOrDefaultAsync(p => p.Id == id, cancellationToken);
        if (todo is null) return false;

        todo.CompletedAt = DateTime.Now;
        await _context.SaveChangesAsync(cancellationToken);
        
        return true;
    }
}
