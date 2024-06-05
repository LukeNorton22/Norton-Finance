using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NortonPFA.Entities;

public class CategoryConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.PlannedAmount)
            .HasColumnType("decimal(18,2)");

        builder.Property(c => c.PaidAmount)
            .HasColumnType("decimal(18,2)");

        builder.HasOne(c => c.ExpenseGroup)
            .WithMany(g => g.Categories)
            .HasForeignKey(c => c.ExpenseGroupId);
    }
}
