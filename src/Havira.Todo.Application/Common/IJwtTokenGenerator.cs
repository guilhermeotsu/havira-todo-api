using Havira.Todo.Domain.Entities;

namespace Havira.Todo.Application.Common;

public interface IJwtTokenGenerator
{
    string GenerateToken(IUser user);
}