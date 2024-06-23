namespace NortonPFA.Entities.DTOs;

public class BudgetDTO
{

    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public List<ExpenseGroup> ExpenseGroups { get; set; } = new List<ExpenseGroup>();
}

public class CreateBudgetDTO
{
    public string Name { get; set; } = string.Empty;
    public Guid UserId { get; set; }
}
