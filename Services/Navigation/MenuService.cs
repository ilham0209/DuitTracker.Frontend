using MudBlazor;

namespace DuitTracker.Frontend.Services.Navigation;

public class MenuService
{
    public List<MenuSection> GetMenuSections()
    {
        return new List<MenuSection>
        {
            new MenuSection
            {
                Title = "Overview",
                Items = new List<MenuItem>
                {
                    new MenuItem { Title = "Dashboard", Icon = Icons.Material.Filled.Dashboard, Href = "/dashboard", ExactMatch = true }
                }
            },
            new MenuSection
            {
                Title = "Finance",
                Items = new List<MenuItem>
                {
                    new MenuItem { Title = "Transactions", Icon = Icons.Material.Filled.SwapHoriz, Href = "/transactions" },
                    new MenuItem { Title = "Budgets", Icon = Icons.Material.Filled.TrackChanges, Href = "/budgets" }
                }
            },
            new MenuSection
            {
                Title = "Management",
                Items = new List<MenuItem>
                {
                    new MenuItem { Title = "Categories", Icon = Icons.Material.Filled.Category, Href = "/categories" },
                    new MenuItem { Title = "Payment Methods", Icon = Icons.Material.Filled.CreditCard, Href = "/payment-methods" }
                }
            },
            new MenuSection
            {
                Title = "Account",
                Items = new List<MenuItem>
                {
                    new MenuItem { Title = "Profile", Icon = Icons.Material.Filled.Person, Href = "/profile" },
                    new MenuItem { Title = "Settings", Icon = Icons.Material.Filled.Settings, Href = "/settings" }
                }
            }
        };
    }
}