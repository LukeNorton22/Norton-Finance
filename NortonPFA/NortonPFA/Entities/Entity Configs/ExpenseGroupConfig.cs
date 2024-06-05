using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NortonPFA.Entities;

public class ExpenseGroupConfig : IEntityTypeConfiguration<ExpenseGroup>
{
    public void Configure(EntityTypeBuilder<ExpenseGroup> builder)
    {
        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasOne(g => g.Budget)
            .WithMany(b => b.ExpenseGroups)
            .HasForeignKey(g => g.BudgetId);

        builder.HasMany(g => g.Categories)
            .WithOne(c => c.ExpenseGroup)
            .HasForeignKey(c => c.ExpenseGroupId);
    }
}
