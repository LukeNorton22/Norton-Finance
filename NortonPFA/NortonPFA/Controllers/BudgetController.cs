using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NortonPFA.Data;
using NortonPFA.Entities;
using NortonPFA.Entities.DTOs;

namespace NortonPFA.Controllers;

[ApiController]
[Route("[controller]")]
public class BudgetController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    [HttpPost("CreateBudget")]
    public async Task<ActionResult<bool>> CreateBudget(CreateBudgetDTO budget)
    {

        var newBudget = new Budget
        {
            Name = budget.Name,
            UserId = budget.UserId
        };

        await _context.Budgets.AddAsync(newBudget);

        await _context.SaveChangesAsync();

        return true;
    }

    [HttpGet("GetAllBudgets")]
    public async Task<ActionResult<List<BudgetDTO>>> GetAllBudgets()
    {
        var result = await _context.Budgets.Select(b => new BudgetDTO
        {
            Id = b.Id,
            Name = b.Name,
            UserId = b.UserId,
            ExpenseGroups = b.ExpenseGroups
        }).ToListAsync();

        return result;
    }

}
