namespace DuitTracker.Frontend.Models.Dashboard;

public class DashboardResponse
{
    public decimal TotalIncome { get; set; }
    public decimal TotalExpense { get; set; }
    public decimal CurrentBalance { get; set; }
    public List<MonthlySummary> MonthlySummary { get; set; } = new();
}

public class MonthlySummary
{
    public int Month { get; set; }
    public int Year { get; set; }
    public decimal TotalIncome { get; set; }
    public decimal TotalExpense { get; set; }
    public decimal Balance { get; set; }
    public List<TopSpendingCategory> TopSpendingCategories { get; set; } = new();
}

public class TopSpendingCategory
{
    public string CategoryName { get; set; } = string.Empty;
    public string CategoryIcon { get; set; } = string.Empty;
    public string CategoryColor { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public double Percentage { get; set; }
}