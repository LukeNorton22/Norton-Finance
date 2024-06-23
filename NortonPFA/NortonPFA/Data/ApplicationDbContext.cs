using Microsoft.EntityFrameworkCore;
using NortonPFA.Entities;

namespace NortonPFA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
        public virtual DbSet<ExpenseGroup> ExpenseGroups { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new BudgetConfig());
            modelBuilder.ApplyConfiguration(new ExpenseGroupConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());

            base.OnModelCreating(modelBuilder);
        }
    }

}
