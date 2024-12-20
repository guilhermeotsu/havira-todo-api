namespace Havira.Todo.Domain.Common;

public class BaseEntity : IComparable<BaseEntity>
{
    public Guid Id { get; set; }

    public int CompareTo(BaseEntity? other)
    {
        if(other is null)
            return 1;

        return other!.Id.CompareTo(Id);
    }
}
