namespace DuitTracker.Frontend.Models.Budgets;

public class BudgetResponse
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryIcon { get; set; } = string.Empty;
    public string CategoryColor { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public decimal TotalSpent { get; set; }
    public decimal Remaining { get; set; }
    public double PercentageUsed { get; set; }
}

public class CreateBudgetRequest
{
    public Guid CategoryId { get; set; }
    public decimal Amount { get; set; }
    public int Month { get; set; } = DateTime.Now.Month;
    public int Year { get; set; } = DateTime.Now.Year;
}

public class EditBudgetRequest
{
    public Guid CategoryId { get; set; }
    public decimal Amount { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
}