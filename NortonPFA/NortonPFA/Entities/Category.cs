namespace NortonPFA.Entities;

public class Category
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal PlannedAmount { get; set; }
    public decimal PaidAmount { get; set; }
    public Guid ExpenseGroupId { get; set; }
    public ExpenseGroup? ExpenseGroup { get; set; }
}
