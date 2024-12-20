using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Text.RegularExpressions;

namespace Havira.Todo.ORM.Mappings;

public class TodoMapping : IEntityTypeConfiguration<Havira.Todo.Domain.Entities.Todo>
{
    public void Configure(EntityTypeBuilder<Havira.Todo.Domain.Entities.Todo> builder)
    {
        builder.ToTable("Todos");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id)
            .HasColumnType("uuid")
            .HasDefaultValueSql("gen_random_uuid()");

        builder.Property(p => p.Title)
            .IsRequired()
            .HasMaxLength(255);
        builder.Property(p => p.Description)
            .IsRequired()
            .HasMaxLength(2048);

        builder.Property(p => p.CreatedAt)
            .HasDefaultValueSql("now()");
        builder.Property(p => p.CompletedAt);

        builder.Property(p => p.UserId)
            .IsRequired();

        builder.HasOne(p => p.User)
            .WithMany(u => u.Todos)
            .HasForeignKey(p => p.UserId)
            .HasConstraintName("FK_Todo_User")
            .OnDelete(DeleteBehavior.SetNull);
    }
}
