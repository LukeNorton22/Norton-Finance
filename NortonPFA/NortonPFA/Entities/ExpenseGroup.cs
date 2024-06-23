namespace NortonPFA.Entities;

public class ExpenseGroup
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid BudgetId { get; set; }
    public Budget? Budget { get; set; }
    public List<Category> Categories { get; set; } = new List<Category>();
}
