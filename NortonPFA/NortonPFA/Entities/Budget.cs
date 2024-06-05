namespace NortonPFA.Entities;

public class Budget
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public List<ExpenseGroup> ExpenseGroups { get; set; } = new List<ExpenseGroup>();
}
