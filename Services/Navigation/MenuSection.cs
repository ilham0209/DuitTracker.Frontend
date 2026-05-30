namespace DuitTracker.Frontend.Services.Navigation;

public class MenuSection
{
    public string Title { get; set; } = string.Empty;
    public List<MenuItem> Items { get; set; } = new();
}